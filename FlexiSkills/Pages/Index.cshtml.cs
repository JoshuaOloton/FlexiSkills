using FlexiSkills.Enums;
using FlexiSkills.Models;
using FlexiSkills.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace FlexiSkills.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FlexiDbContext _flexiDbContext;
        private readonly StudentDbContext _studentDbContext;
        private readonly IPaymentService _paymentService;

        public IQueryable<Models.Student.VwCourse> VwCourses { get; private set; }
        public Models.Student.VwStudentRecord1 Student { get; set; }
        public Models.Student.ProgrammeType StudentProgram { get; set; }
        public IQueryable<Models.EBPortal.Transaction> StudentPayments { get; set; }
        public Models.EBPortal.Transaction FlexPayment { get; set; }
        public Models.Flexi.Student? SubmittedRecord { get; set; }
        public int TotalFeesDue { get; set; }
        public String? RemitaRRR { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FlexiDbContext flexiDbContext, StudentDbContext studentDbContext, IPaymentService paymentService)
        {
            _logger = logger;
            _flexiDbContext = flexiDbContext;
            _studentDbContext = studentDbContext;
            _paymentService = paymentService;
        }

        public async Task<IActionResult?> OnGet()
        {

            try
            {
                String matrno = User.Claims.First(x => x.Type == "MatricNo").Value;

                //GenerateModel generateModel = new();
                this.VwCourses = GetCourses();

                //this.SubmittedRecord = context.Students.Where(x => x.Matricno == matrno).Include(x => x.Courses).SingleOrDefault();

                this.SubmittedRecord = (from record in _flexiDbContext.Students
                                   where record.Matricno == matrno
                                   && record.SemesterId == this.StudentProgram.Semesterid
                                   && record.SessionId == this.StudentProgram.Asessionid
                                   select record).Include("Courses").FirstOrDefault();

                Console.WriteLine($"Semester ID: {this.StudentProgram.Semesterid}");
                Console.WriteLine($"Session ID: {this.StudentProgram.Asessionid}");

                if (this.SubmittedRecord == null)
                    return Redirect("/Generate");

                //Sum up all units in selected courses and determine fees due   
                int totUnits = this.SubmittedRecord.Courses.Sum(course => Convert.ToInt32(course.CourseUnit));
                this.TotalFeesDue = totUnits * 1800;
                
                return null;
            }
            catch (SqlException)
            {
                return Redirect("/Index");
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _ = GetCourses();

            String matrno = User.Claims.First(x => x.Type == "MatricNo").Value;
            this.SubmittedRecord = (from record in _flexiDbContext.Students
                                    where record.Matricno == matrno
                                    && record.SemesterId == this.StudentProgram.Semesterid
                                    && record.SessionId == this.StudentProgram.Asessionid
                                    select record).Include("Courses").FirstOrDefault();

            Console.WriteLine($"Semester ID: {this.StudentProgram.Semesterid}");
            Console.WriteLine($"Session ID: {this.StudentProgram.Asessionid}");

            if (this.SubmittedRecord == null)
                return Redirect("/Generate");

            //Sum up all units in selected courses and determine fees due   
            int totUnits = this.SubmittedRecord.Courses.Sum(course => Convert.ToInt32(course.CourseUnit));
            this.TotalFeesDue = totUnits * 1800;

            String applicantName = this.Student.Surname.Trim() + " " + this.Student.Firstname.Trim();
            String applicantPhone = this.Student.Phone.Trim();
            String applicantEmail = this.Student.Email.Trim();
            String payeenum = this.Student.Matricnum.Trim();
            String? sessionName = this.Student.Acadsession.Trim();

            var remita = await _paymentService.GenerateRRR(
                this.TotalFeesDue.ToString().Trim(),
                applicantName,
                applicantPhone,
                applicantEmail,
                "ODFEL LEARNING FEES",
                payeenum,
                "5",
                sessionName);

            // Sign applicant out and redirect to remita payments page
            await HttpContext.SignOutAsync();

            return Redirect($"https://onlinepay.yabatech.edu.ng/?v1={remita}");
        }

        // Handler function triggered when final course submission is clicked
        public async Task<IActionResult?> OnGetSubmit()
        {
            try
            {
                ServiceReference1.yctoutserviceSoapClient client = new ServiceReference1.yctoutserviceSoapClient(
                    ServiceReference1.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);

                _ = GetCourses();

                var studentRecord = (from record in _flexiDbContext.Students
                                        where record.Matricno == this.Student.Matricnum
                                        && record.SemesterId == this.StudentProgram.Semesterid
                                        && record.SessionId == this.StudentProgram.Asessionid
                                        select record).Include("Courses").FirstOrDefault();
                studentRecord.FinalSubmission = 1;
                _flexiDbContext.SaveChanges();
                this.SubmittedRecord = studentRecord;

                /* sum up total units of all courses concatenate all course codes into single string */
                List<String> courseCodes = new List<String>();
                for (int i = 0; i < this.SubmittedRecord.Courses.Count; i++)
                {
                    var course = this.SubmittedRecord.Courses.ToList()[i];
                    courseCodes.Add(course.CourseCode.ToString());
                }

                String concatCourseCodes = String.Join(':', courseCodes);
                // call SOAP API to submit courses to dbo.registrations table
                var result1 = await client.register_student2Async(
                    this.Student.Matricnum,
                    (int)this.StudentProgram.Semesterid,
                    (int)this.StudentProgram.Asessionid,
                    Convert.ToInt32(this.Student.Level),
                    concatCourseCodes,
                    Convert.ToInt32(this.Student.ProgrammeId),
                    this.StudentProgram.ProgrammeTypeId
                    );

                //var result1 = await client.register_studentAsync(
                //    this.Student.Matricnum,
                //    (int)this.StudentProgram.Semesterid,
                //    (int)this.StudentProgram.Asessionid,
                //    Convert.ToInt32(this.Student.Level),
                //    concatCourseCodes
                //    );
                Notify(message: "You have successfully registered your courses!", notificationType: NotificationType.success);

                return Page();
            }
            catch (SqlException)
            {
                return Redirect("/Index");
            }
        }

        public async Task<IActionResult?> OnGetAddCoursesAfterPayment()
        {
            try
            {
                var studentRecord = (from record in _flexiDbContext.Students
                                     where record.Matricno == this.Student.Matricnum
                                     && record.SemesterId == this.StudentProgram.Semesterid
                                     && record.SessionId == this.StudentProgram.Asessionid
                                     select record).Include("Courses").FirstOrDefault();
                studentRecord.FinalSubmission = 1;

                return null;
            }
            catch (SqlException)
            {
                return Redirect("/Index");
            }
        }

        public IQueryable<Models.Student.VwCourse> GetCourses()
        {
            // Fetch user information from claims
            String matno = User.Claims.FirstOrDefault(x => x.Type == "MatricNo").Value;

            StudentDbContext studentDb = new();
            var student = (from record in studentDb.VwStudentRecord1s
                           where record.Matricnum == matno
                           select record).SingleOrDefault();
            this.Student = student;

            var program = (from record in studentDb.ProgrammeTypes
                           where record.ProgrammeType1 == student.ProgrammeType
                           select record).SingleOrDefault();
            this.StudentProgram = program;

            var courses = (from record in studentDb.VwCourses
                           where record.ASessionId == program.Asessionid.ToString()
                           && record.SemesterId == program.Semesterid.ToString()
                           && record.ProgrammeTypeId == program.ProgrammeTypeId.ToString()
                           && record.ProgrammeId == student.ProgrammeId
                           && record.LevelId == student.Level
                           select record);
            this.VwCourses = courses;

            return courses;
        }

        public void Notify(String message, NotificationType notificationType = NotificationType.success)
        {
            var msg = new
            {
                message = message,
                type = notificationType.ToString()
            };
            TempData["notification"] = JsonSerializer.Serialize(msg);
        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            var encodedString = System.Convert.ToBase64String(plainTextBytes);
            //var decodedBytes = System.Convert.FromBase64String(encodedString);
            return encodedString;
        }

    }
}
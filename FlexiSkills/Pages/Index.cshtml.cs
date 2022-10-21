using FlexiSkills.Enums;
using FlexiSkills.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace FlexiSkills.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FlexiDbContext flexiDbContext;

        public IQueryable<Models.Student.VwCourse> VwCourses { get; private set; }
        public Models.Student.VwStudentRecord1 Student { get; set; }
        public Models.Student.ProgrammeType StudentProgram { get; set; }
        public IQueryable<Models.EBPortal.Transaction> StudentPayments { get; set; }
        public Models.EBPortal.Transaction FlexPayment { get; set; }
        public Models.Flexi.Student SubmittedRecord { get; set; }
        public int TotalFeesDue { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FlexiDbContext flexiDbContext)
        {
            _logger = logger;
            this.flexiDbContext = flexiDbContext;
        }

        public IActionResult? OnGet()
        {

            try
            {
                String matrno = User.Claims.First(x => x.Type == "MatricNo").Value;

                //GenerateModel generateModel = new();
                this.VwCourses = GetCourses();

                var context = flexiDbContext;
                this.SubmittedRecord = context.Students.Where(x => x.Matricno == matrno).Include(x => x.Courses).SingleOrDefault();

                if (this.SubmittedRecord == null)
                    return Redirect("/Generate");

                //String[] x;

                int totUnits = 0;
                for (int i = 0; i < this.SubmittedRecord.Courses.Count; i++)
                {
                    // sum up total units of all courses
                    var course = this.SubmittedRecord.Courses.ToList()[i];
                    totUnits += Convert.ToInt32(course.CourseUnit);
                }
                this.TotalFeesDue = totUnits * 1800;

                StudentDbContext studentDbContext = new();

                var record = (from rec in studentDbContext.RegistrationDisplays
                              where rec.MatricNo == matrno
                              select rec).FirstOrDefault();
                if (record != null)
                {
                    this.SubmittedRecord.FinalSubmission = 1;
                    context.SaveChanges();
                }

                return null;
            }
            catch (SqlException)
            {
                return Redirect("/Index");
            }
        }

        public async void OnPostAsync()
        {
            await HttpContext.SignOutAsync();
        }

        // Handler function triggered when final course submission is clicked
        public IActionResult? OnGetSubmit()
        {
            try
            {
                ServiceReference1.yctoutserviceSoapClient client = new ServiceReference1.yctoutserviceSoapClient(
                ServiceReference1.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);
                var result = client.Test();

                _ = GetCourses();

                var context = flexiDbContext;
                var studentRecord = context.Students.Where(x => x.Matricno == this.Student.Matricnum)
                    .Include(x => x.Courses).SingleOrDefault();
                studentRecord.FinalSubmission = 1;
                context.SaveChanges();
                this.SubmittedRecord = studentRecord;

                int totUnits = 0;
                List<String> courseIDs = new List<String>();
                for (int i = 0; i < this.SubmittedRecord.Courses.Count; i++)
                {
                    // sum up total units of all courses
                    var course = this.SubmittedRecord.Courses.ToList()[i];

                    //concatenate ids of all courses into single string
                    courseIDs.Add(course.DboCourseId.ToString());
                }

                String concatIDs = String.Join(':', courseIDs);
                // call SOAP API to submit courses to dbo.registrations table
                var result1 = client.register_student(
                    this.Student.Matricnum,
                    (int)this.StudentProgram.Semesterid,
                    (int)this.StudentProgram.Asessionid,
                    Convert.ToInt32(this.Student.Level),
                    concatIDs
                    );
                Notify(message: "You have successfully registered your courses!", notificationType: NotificationType.success);

                return (null);
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

    }
}
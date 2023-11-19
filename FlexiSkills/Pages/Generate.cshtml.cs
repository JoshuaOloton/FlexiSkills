using FlexiSkills.Enums;
using FlexiSkills.Models;
using FlexiSkills.Models.EBPortal;
using FlexiSkills.Pages.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace FlexiSkills.Pages
{
    [Authorize]
    public class GenerateModel : PageModel
    {
        private readonly FlexiDbContext _flexiDbContext;

        public IQueryable<Models.Student.VwCourse> VwCourses { get; private set; }
        public Models.Student.StudentRecord Student { get; set; }
        public Models.Student.ProgrammeType StudentProgram { get; set; }
        public Models.Flexi.Student? SubmittedRecord { get; set; }
        public bool HasCarryOver { get; set; }
        public List<COCourse> COCourses { get; set; } = new();

        public GenerateModel(FlexiDbContext flexiDbContext)
        {
            _flexiDbContext = flexiDbContext;
        }

        public async Task<IActionResult?> OnGetAsync()
        {
            try
            {
                await GetCourses();
                if (!this.VwCourses.Any())
                {
                    await HttpContext.SignOutAsync();
                    Notify("No courses available! Please try again later.", NotificationType.error);
                    return Redirect("/Account/Login");
                }
                //this.SubmittedRecord = flexiDbContext.Students.Where(x => x.Matricno == this.Student.Matricnum).Include(x => x.Courses).FirstOrDefault();

                this.SubmittedRecord = (from record in _flexiDbContext.Students
                                   where record.Matricno == this.Student.Matricnum
                                   && record.SemesterId == this.StudentProgram.Semesterid
                                   && record.SessionId == this.StudentProgram.Asessionid
                                   select record).Include("Courses").FirstOrDefault();

                // CHECK IF STUDENT HAS CARRYOVER IF STUDENT IS YET TO SELECT COURSES
                if (this.SubmittedRecord == null)
                {
                    Console.WriteLine("NULLLL");
                    //ServiceReference1.yctoutserviceSoapClient client = new(
                    //    ServiceReference1.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);
                    //int status = await client.retrun_stud_stateAsync(this.Student.Matricnum, this.StudentProgram.Semesterid.ToString(), this.StudentProgram.Asessionid.ToString());
                    //Console.Out.WriteLine("STATUS");
                    //Console.Out.WriteLine(status);
                    //if (status == 3)
                    //{
                    //    this.HasCarryOver = true;

                    //    var response = await client.retrun_co_courseAsync("D/ND/21/3910003", "1", "7");
                    //    var responseContent = response.Any1;

                    //    var tables = responseContent.FirstChild?.SelectNodes("Table");

                    //    for (int i = 0; i < tables?.Count; i++)
                    //    {
                    //        var tableElements = tables.Item(i)?.ChildNodes;

                    //        this.COCourses.Add(new COCourse
                    //        {
                    //            CourseID = Convert.ToInt32(tableElements?.Item(0)?.InnerText),
                    //            CourseCode = tableElements?.Item(1)?.InnerText,
                    //            CourseTitle = tableElements?.Item(2)?.InnerText,
                    //            CourseUnit = tableElements?.Item(3)?.InnerText
                    //        });
                    //        //Console.WriteLine($"CourseCode: {tableElements?.Item(1)?.InnerText}");
                    //        //Console.WriteLine($"CourseTitle: {tableElements?.Item(2)?.InnerText}");
                    //        //Console.WriteLine($"CourseUnit: {tableElements?.Item(3)?.InnerText}");
                    //        //Console.WriteLine();
                    //    }
                    //    // Transfer this toast message to only show on index page load with message 
                    //    Notify(message: "Please register carryover courses for this semester.", notificationType: NotificationType.info);
                    //}
                }
                return null;
            }
            catch (SqlException)
            {
                return Redirect("/Generate");
            }
        }

        public async Task<IActionResult> OnPost(String[] CourseCode)
        {
            try
            {
                Console.WriteLine("Course Codes");
                Console.WriteLine(CourseCode);
                if (CourseCode.Length == 0)
                {
                    Notify(message: "Select at least one course to continue!", notificationType: NotificationType.error);
                    return Redirect("/Generate");
                }

                // Obtain Student's information with GetCourses() function
                await GetCourses();

                using (var context = new FlexiDbContext())
                {
                    bool is_null = false;
                    // Create new Student Record in flexi_db if student does not exist/has not previously submitted
                    var student = context.Students.Include(x => x.Courses).FirstOrDefault(x => 
                        x.Matricno == this.Student.Matricnum
                        && x.SemesterId == this.StudentProgram.Semesterid
                        && x.SessionId == this.StudentProgram.Asessionid);
                    if (student != null)
                    {
                        student.IsSubmitted++;
                    }
                    else
                    {
                        is_null = true;
                        student = new Models.Flexi.Student
                        {
                            Surname = this.Student.Surname,
                            Firstname = this.Student.Firstname,
                            Matricno = this.Student.Matricnum,
                            AmountPaid = 0,
                            IsSubmitted = 1,
                            FinalSubmission = 0,
                            TotalUnits = 0,
                            SemesterId = (int)StudentProgram.Semesterid,
                            SessionId = (int)this.StudentProgram.Asessionid
                        };
                    }

                    // update previous courses with the newly selected ones
                    student.Courses.Clear();

                    int totUnits = 0;
                    // iterate over selected courses, sum up all their units and add them to db
                    foreach (var cs_code in CourseCode)
                    {
                        // Use course codes to query the full course record
                        var c = (from rec in this.VwCourses
                                 where rec.CourseCode == cs_code &&
                                 rec.ASessionId == this.StudentProgram.Asessionid.ToString() &&
                                 rec.SemesterId == this.StudentProgram.Semesterid.ToString() &&
                                 rec.ProgrammeTypeId == this.StudentProgram.ProgrammeTypeId.ToString()
                                 select rec).FirstOrDefault();

                        if (c == null)
                        {
                            StudentDbContext studentDb = new();
                            var moreCourses = (from record in studentDb.VwCourses
                                               where record.ProgrammeTypeId == this.StudentProgram.ProgrammeTypeId.ToString()
                                               && record.ProgrammeId == this.Student.ProgrammeId
                                               select record);

                            c = (from co_course in this.COCourses
                                      join vwCourse in moreCourses
                                      on co_course.CourseID equals vwCourse.Id
                                      where co_course.CourseCode == cs_code
                                      select vwCourse).FirstOrDefault();
                        }

                        // Create new Flexi course object/record from VwCourses
                        var course = new Models.Flexi.Course
                        {
                            CourseUnit = c.CourseUnit,
                            CourseCode = c.CourseCode,
                            CourseTitle = c.CourseTitle,
                            DboCourseId = c.Id,
                            SemesterId = c.SemesterId,
                            SessionId = c.ASessionId
                        };

                        totUnits += System.Convert.ToInt32(c.CourseUnit);
                        student.Courses.Add(course);
                    }
                    if (totUnits < 8)
                    {
                        Notify(message: "You must select at least 8 units to continue!", notificationType: NotificationType.error);
                        return Redirect("/Generate");
                    }
                    student.TotalUnits = totUnits;
                    student.TotalFeesDue = 1800 * student.TotalUnits;
                    if (is_null) // no flexidb student record
                        context.Students.Add(student);
                    context.SaveChanges();

                    return Redirect("/Index");
                }
            }
            catch(SqlException)
            {
                return Redirect("/Generate");
            }
        }

        public async Task GetCourses()
        {
            // Fetch user information from claims
            String matno = User.Claims.FirstOrDefault(x => x.Type == "MatricNo").Value;

            StudentDbContext studentDb = new();
            var student = (from record in studentDb.StudentRecords
                           where record.Matricnum == matno
                           select record).FirstOrDefault();
            this.Student = student;

            var program = (from record in studentDb.ProgrammeTypes
                           where record.ProgrammeType1 == student.ProgrammeType
                           select record).FirstOrDefault();
            this.StudentProgram = program;

            var courses = (from record in studentDb.VwCourses
                           where record.ASessionId == program.Asessionid.ToString()
                           && record.SemesterId == program.Semesterid.ToString()
                           && record.ProgrammeTypeId == program.ProgrammeTypeId.ToString()
                           && record.ProgrammeId == student.ProgrammeId
                           && record.LevelId == student.Level
                           select record);
            this.VwCourses = courses;

            ServiceReference1.yctoutserviceSoapClient client = new(
                        ServiceReference1.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);
            int status = await client.retrun_stud_stateAsync(this.Student.Matricnum, this.StudentProgram.Semesterid.ToString(), this.StudentProgram.Asessionid.ToString());
            Console.Out.WriteLine("STATUS");
            Console.Out.WriteLine(status);
            if (status == 3)
            {
                this.HasCarryOver = true;

                var response = await client.retrun_co_courseAsync("D/ND/21/3910003", "1", "7");
                var responseContent = response.Any1;

                var tables = responseContent.FirstChild?.SelectNodes("Table");

                for (int i = 0; i < tables?.Count; i++)
                {
                    var tableElements = tables.Item(i)?.ChildNodes;

                    this.COCourses.Add(new COCourse
                    {
                        CourseID = System.Convert.ToInt32(tableElements?.Item(0)?.InnerText),
                        CourseCode = tableElements?.Item(1)?.InnerText,
                        CourseTitle = tableElements?.Item(2)?.InnerText,
                        CourseUnit = tableElements?.Item(3)?.InnerText
                    });
                }
                // Transfer this toast message to only show on index page load with message 
                Notify(message: "Please register carryover courses for this semester.", notificationType: NotificationType.info);
            }
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

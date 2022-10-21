using FlexiSkills.Enums;
using FlexiSkills.Models;
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
        public IQueryable<Models.Student.VwCourse> VwCourses { get; private set; }
        public Models.Student.StudentRecord Student { get; set; }
        public Models.Student.ProgrammeType StudentProgram { get; set; }
        public Models.Flexi.Student SubmittedRecord { get; set; }

        public GenerateModel()
        {
                
        }

        public async Task<IActionResult?> OnGetAsync()
        {
            try
            {
                FlexiDbContext flexiDbContext = new();

                this.VwCourses = GetCourses();
                if (!this.VwCourses.Any())
                {
                    await HttpContext.SignOutAsync();
                    Notify("No courses available! Please try again later.", NotificationType.error);
                    return Redirect("/Account/Login");
                }
                this.SubmittedRecord = flexiDbContext.Students.Where(x => x.Matricno == this.Student.Matricnum).Include(x => x.Courses).FirstOrDefault();
                return null;
            }
            catch (SqlException)
            {
                return Redirect("/Generate");
            }
        }

        public IActionResult OnPost(String[] CourseCode)
        {
            try
            {
                if (CourseCode.Length == 0)
                {
                    Notify(message: "Select at least one course to continue!", notificationType: NotificationType.error);
                    return Redirect("/Generate");
                }

                // Obtain Student's information with GetCourses() function
                _ = GetCourses();

                using (var context = new FlexiDbContext())
                {
                    bool is_null = false;
                    // Create new Student Record in flexi_db if student does not exist/has not previously submitted
                    var student = context.Students.Include(x => x.Courses).SingleOrDefault(x => x.Matricno == this.Student.Matricnum);
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
                                 where rec.CourseCode == cs_code
                                 select rec).SingleOrDefault();

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

                        totUnits += Convert.ToInt32(c.CourseUnit);
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

        public IQueryable<Models.Student.VwCourse> GetCourses()
        {
            // Fetch user information from claims
            String matno = User.Claims.FirstOrDefault(x => x.Type == "MatricNo").Value;

            StudentDbContext studentDb = new();
            var student = (from record in studentDb.StudentRecords
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

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
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

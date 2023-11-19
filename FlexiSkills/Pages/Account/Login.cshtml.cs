using FlexiSkills.Enums;
using FlexiSkills.FormModels;
using FlexiSkills.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using System.Security.Claims;
using System.Text.Json;

namespace FlexiSkills.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly FlexiDbContext _flexiDbContext;
        private readonly EBPortalDbContext _eBPortalDbContext;
        private readonly StudentDbContext _studentDbContext;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(FlexiDbContext flexiDbContext, EBPortalDbContext eBPortalDbContext, StudentDbContext studentDbContext)
        {
            _flexiDbContext = flexiDbContext;
            _eBPortalDbContext = eBPortalDbContext;
            _studentDbContext = studentDbContext;
        }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync(string? returnUrl)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var student = (from record in _studentDbContext.VwStudentRecord1s
                                   where record.Matricnum == Model.MatricNo && record.Password == Model.Password
                                   && (record.ProgrammeTypeId == 11 || record.ProgrammeTypeId == 12)
                                   select record).SingleOrDefault();
                    if (student == null)
                    {
                        Notify(message: "Please check your Matric No./Password and verify you are an ODFEL student!", notificationType: NotificationType.error);
                        return Page();
                    }

                    var studentProgram = (from record in _studentDbContext.ProgrammeTypes
                                          where record.ProgrammeType1 == student.ProgrammeType
                                          select record).SingleOrDefault();

                    if (studentProgram == null)
                    {
                        Notify(message: "Login Failed! Please confirm your records are up to date.", notificationType: NotificationType.error);
                        return Page();
                    }

                    String isSubmitted = "false";

                    // Check if student's record exists in Flexi db

                    //var student_rec = context.Students.Where(x => x.Matricno == student.Matricnum).Include(x => x.Courses).SingleOrDefault();

                    var student_rec = (from record in _flexiDbContext.Students
                                       where record.Matricno == student.Matricnum
                                       && record.SemesterId == studentProgram.Semesterid
                                       && record.SessionId == studentProgram.Asessionid
                                       select record).Include("Courses").FirstOrDefault();

                    //student_rec.Courses.

                    List<Models.EBPortal.Transaction> payments;
                    if (student_rec == null)
                    {
                        payments = (from record in _eBPortalDbContext.Transactions
                                    where record.Payeenum == student.Matricnum
                                    && record.Sessionid == studentProgram.Asessionid + 31
                                    && (record.Paymentid == 5 || record.Paymentid == 70)
                                    && record.ApprovedAmount == "28000"
                                    select record).ToList();
                    }
                    else
                    {
                        payments = (from record in _eBPortalDbContext.Transactions
                                    where record.Payeenum == student.Matricnum
                                    && record.Sessionid == studentProgram.Asessionid + 31
                                    && (record.Paymentid == 5 || record.Paymentid == 70)
                                    && record.SemesterId == studentProgram.Semesterid
                                    //&& Convert.ToInt32(record.ApprovedAmount) >= 28000
                                    select record).ToList();
                        
                        if (studentProgram.Semesterid == 1)     // semester = 1
                        {
                            
                            if (payments.Any())
                            {
                                int pay = payments.Sum(payment => Convert.ToInt32(payment.ApprovedAmount));
                                if (student_rec.TotalFeesDue - (pay) <= 0)
                                {
                                    student_rec.AmountPaid = student_rec.TotalFeesDue;
                                    _flexiDbContext.SaveChanges();
                                }
                            }
                        }
                        else    // semester = 2
                        {
                            if (payments.Any())
                            {
                                int pay = payments.Sum(payment => Convert.ToInt32(payment.ApprovedAmount));

                                if (student_rec.TotalFeesDue - pay <= 0)
                                {
                                    student_rec.AmountPaid = student_rec.TotalFeesDue;
                                    _flexiDbContext.SaveChanges();
                                }
                            }
                        }
                        isSubmitted = "true";
                    }

                    ServiceReference1.yctoutserviceSoapClient client = new(
                        ServiceReference1.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);
                    var result = await client.retrun_stud_stateAsync(student.Matricnum, studentProgram.Semesterid.ToString(), studentProgram.Asessionid.ToString());
                    Console.WriteLine("RESULT");
                    Console.WriteLine(result);
                    if (result == 1)
                    {
                        Notify(message: "You are not qualified to register for this semester.", notificationType: NotificationType.error);
                        return Page();
                    }
                    else if (result == 4)
                    {
                        Notify(message: "Disciplinary action has been taken against you!", notificationType: NotificationType.error);
                        return Page();
                    }

                    if ((studentProgram.Semesterid == 1 && payments.Any()) || studentProgram.Semesterid == 2)
                    {
                        // Student supplied correct credentials and has paid for the current semester
                        var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name, student.Firstname),
                            new Claim(ClaimTypes.Surname, student.Surname),
                            new Claim(ClaimTypes.Email, student.Email),
                            new Claim("MatricNo", student.Matricnum),
                            new Claim("HasSubmitted", isSubmitted)
                        };
                        ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal claimsPrincipal = new(claimsIdentity);

                        await HttpContext.SignInAsync(claimsPrincipal);
                        //Notify(message: "Login Successful!");
                        if (returnUrl == null)
                        {
                            return RedirectToPage("/Index");
                        }
                        return Redirect(returnUrl);
                    }
                }
                Notify(message: "Login Failed! Please confirm your fee payments are up to date", notificationType: NotificationType.error);
                return Page();
            }
            catch (SqlException ex)
            {
                Notify(message: ex.Message, notificationType: NotificationType.error);
                return Redirect("/Account/Login");
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

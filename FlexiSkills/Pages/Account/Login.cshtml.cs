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

        [BindProperty]
        public Login Model { get; set; }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync(string? returnUrl)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    StudentDbContext studentContext = new();

                    var student = (from record in studentContext.VwStudentRecord1s
                                   where record.Matricnum == Model.MatricNo && record.Password == Model.Password
                                   && (record.ProgrammeTypeId == 11 || record.ProgrammeTypeId == 12)
                                   select record).SingleOrDefault();
                    if (student == null)
                    {
                        Notify(message: "Please check your Matric No./Password and verify you are a Flexible skill student!", notificationType: NotificationType.error);
                        return Page();
                    }

                    var studentProgram = (from record in studentContext.ProgrammeTypes
                                          where record.ProgrammeType1 == student.ProgrammeType
                                          select record).SingleOrDefault();

                    if (studentProgram == null)
                    {
                        Notify(message: "Login Failed!", notificationType: NotificationType.error);
                        return Page();
                    }

                    String isSubmitted = "false";

                    // Check if studet's record exists in Flexi db
                    var context = new FlexiDbContext();

                    var student_rec = context.Students.Where(x => x.Matricno == student.Matricnum).Include(x => x.Courses).SingleOrDefault();

                    EBPortalDbContext eBPortalDbContext = new();
                    IQueryable<Models.EBPortal.Transaction> payments;
                    if (student_rec == null)
                    {
                        payments = (from record in eBPortalDbContext.Transactions
                                    where record.Payeenum == student.Matricnum
                                    && record.Sessionid == studentProgram.Asessionid + 31
                                    && (record.Paymentid == 5 || record.Paymentid == 70)
                                    && record.ApprovedAmount == "28000"
                                    select record);
                    }
                    else
                    {
                        payments = (from record in eBPortalDbContext.Transactions
                                    where record.Payeenum == student.Matricnum
                                    && record.Sessionid == studentProgram.Asessionid + 31
                                    && record.Paymentid == 5
                                    //&& Convert.ToInt32(record.ApprovedAmount) >= 28000
                                    select record);
                        if (payments.Any())
                        {
                            int pay = 0;
                            foreach (var payment in payments)
                            {
                                pay += Convert.ToInt32(payment.ApprovedAmount);
                            }
                            if (student_rec.TotalFeesDue - (pay - 28000) == 0)
                            {
                                student_rec.AmountPaid = student_rec.TotalFeesDue;
                                context.SaveChanges();
                            }
                        }
                        isSubmitted = "true";
                    }

                    if (payments.Any())
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
                        Notify(message: "Login Successful!");
                        if (returnUrl == null)
                        {
                            return RedirectToPage("/Index");
                        }
                        return Redirect(returnUrl);
                    }
                }
                Notify(message: "Login Failed!", notificationType: NotificationType.error);
                return Page();
            }
            catch (SqlException)
            {
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

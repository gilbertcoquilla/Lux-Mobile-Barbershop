using LuxMobile.Models;
using LuxMobile.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using LuxMobile.Areas.Identity.Pages.Account;
using System.Net.Mail;
using System.Net;

namespace LuxMobile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactView record)
        {
            using (MailMessage mail = new MailMessage("LMB.ContactUs@gmail.com", record.Email))
            {
                mail.Subject = record.Subject;

                string message = "Hello, " + record.SenderName + "!<br/><br/> Thank you for reaching out! I hope you are having a great day. This auto-reply is just to let you know that" +
                    " we have received your inquiry. <br/><br/>These are the details we've gathered: <br/><br/>" +
                    "Contact Number: <strong> " + record.ContactNo + "<br/><br/></strong> Message: <br/><strong>" + record.Message + "</strong><br/><br/>" +
                    " We will get back to you as soon as possible. If you have questions about our services, check out our About Us page for more details. <br/></br><br/>" +
                    "If you have any additional information that you think will help us to assist you, feel free to reply to this email. <br/><br/><br/> " +
                    "Stay safe!<br/><br/><br/> Best Regards, <br/> LUX Mobile Team";
                mail.Body = message;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("LMB.ContactUs@gmail.com", "Luxx2020");
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mail);
                    ViewBag.Message = "Inquiry sent.";
                }
            }
            ModelState.Clear();
            return View();
        }

        public IActionResult Error2()
        {
            return View();
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

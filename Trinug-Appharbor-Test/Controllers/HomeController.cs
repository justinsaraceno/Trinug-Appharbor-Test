using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Typesafe.Mailgun;

namespace Trinug_Appharbor_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to TRINUG.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is my trinug appharbor demo site.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendMail()
        {
            /* Send test email. */
            var client = new MailgunClient("smtp.mailgun.org", "key-5f7yfgqia6tenaxlae5eada956lf8nn3");
            client.SendMail(new System.Net.Mail.MailMessage("welcome@trinug-test.apphb.com", "justinsaraceno@gmail.com")
            {
                Subject = "Hello from AppHarbor and Mailgun",
                Body = "this is a test message from Appharbor using the Mailgun add-in."
            });

            return View("Contact");
        }
    }
}

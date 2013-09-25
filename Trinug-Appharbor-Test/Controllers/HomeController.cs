using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Trinug_Appharbor_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to TekSystems.";

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
            var client = new SmtpClient();
            var message = new MailMessage(
                "test@trinug-test.com",
                "justin.saraceno@gmail.com",
                "Test email from AppHarbor",
                "This is a test message using AppHarbot and Mailgun.");

            client.Send(message);

            return View("Contact");
        }
    }
}

using MvcRuslana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MvcRuslana.Controllers
{
    public class MedlemsskapController : Controller
    {
        //
        // GET: /Medlemsskap/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ApplyMember()
        {
            Medlem medlem = new Medlem();
            return View(medlem);
        }

        [HttpPost]
        public ActionResult ApplyMember(Medlem medlem)
        {
            string Text = @"Namn: " + medlem.Namn +
            "Epost : " + medlem.Email +
            "Meddelande: " + medlem.Meddelande;

            SendEmail(Text);
            return View("MedlemConfirm");
        }

        public static void SendEmail(string Text)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("noreply@ruslana.se");
            msg.To.Add("uais@live.se");
            msg.Subject = "Ny anmälan Medlemsskap ruslana.se";
            msg.Body = Text;
            msg.Priority = MailPriority.High;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("mail.ruslana.se", 587);
            client.Credentials = new System.Net.NetworkCredential("noreply@ruslana.se", "@%Kr</Ia");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
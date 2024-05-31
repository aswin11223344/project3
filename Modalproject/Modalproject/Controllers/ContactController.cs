using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Modalproject.Models;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;



namespace Modalproject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult contact() { return View(); }

        

        [HttpPost]
        public IActionResult contact(string name, string email,string subject,string message)
        {
        MailMessage mail = new MailMessage();
            mail.From = new MailAddress("opmi4148@gmail.com");
            mail.To.Add(new MailAddress("opmi4148@gmail.com"));
            mail.Subject = "confirmation message";
            mail.IsBodyHtml= false;
            mail.Body = $" Name : {name}\n Email:{email}\n Subject:{subject}\n Message:{message}";
            SmtpClient smtp=new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential("opmi4148@gmail.com", "athw fayr irrz cpso");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);

            }catch (Exception)
            {
                ViewBag.failed = "Unable to send mail right now";
            }
            if(ModelState.IsValid)
            {
                ViewBag.success = "Mail sent successfully";
            }

            return Redirect("Success");
        }
        public IActionResult Success() { return View(); }   
    }
}

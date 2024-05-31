using Microsoft.AspNetCore.Mvc;
using Modalproject.Models;
using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;

using static System.Net.Mime.MediaTypeNames;

namespace Modalproject.Controllers
{
    public class RegistrationController : Controller
    {
        string uploadpath;
        string Modal; 
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Registration(Registration registration, IFormFile myfile)
        {
            var returnpage = "Registration";
            var a = "a";
            string res = string.Join(",", registration.Hobbies);
            string connectionstring= " Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Arun; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {




                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert INTO Registration(FirstName,LastName,DateOfBirth,Gender,Email,PhoneNumber,Country,State,City,Hobbies)" +
                                   "VALUES(@FirstName,@LastName,@DateOfBirth,@Gender,@Email,@PhoneNumber,@Country,@State,@City,@Hobbies)", connection);
                cmd.Parameters.AddWithValue("@FirstName", registration.FirstName);
                cmd.Parameters.AddWithValue("@LastName", registration.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", registration.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", registration.Gender);
                cmd.Parameters.AddWithValue("@Email", registration.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", registration.PhoneNumber);
                cmd.Parameters.AddWithValue("@Country", registration.Country);
                cmd.Parameters.AddWithValue("@State", registration.State);
                cmd.Parameters.AddWithValue("@City", registration.City);
                cmd.Parameters.AddWithValue("@Hobbies", registration.Hobbies);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MailMessage mail = new MailMessage();


            mail.From =new MailAddress(registration.Email);
            mail.To.Add(new MailAddress(registration.Email));
            mail.Subject = "Registration form";
            mail.IsBodyHtml = true;
            mail.Body = "<h2>Registratyion Successful</h2>";
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("opmi4148@gmail.com", "opmi4148@gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);





            return View(returnpage);
        }
     
            

        

    
    }

}

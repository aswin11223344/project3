using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Modalproject.Models
{
    public class Login
    {
       static void Main()
        {
            Console.WriteLine("Enter your email address:");
            string email=Console.ReadLine();
            string tempPassword = GenerateTemporaryPassword();
            
            Console.WriteLine("Enter the temporary password received via email:");
            string enteredPassword=Console.ReadLine();
            if(enteredPassword ==tempPassword)
            {
                Console.WriteLine("Temporary password accepted. Please set a new password.");
                string newPassword=Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Incorrect temporary password.Please try again.");
            }
        }
        static string GenerateTemporaryPassword()
        {
            return
                Guid.NewGuid().ToString().Substring(0,8);
            static void SendEmail(string email, string tempPassword)
            {
                SendEmail(email, tempPassword);
                MailMessage mail = new MailMessage("opmi4148@gmail.com",email);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod=SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials=false;
                client.Host = "smtp.gmail.com";
                mail.Subject = "Temporary Password";
                mail.Body=$"Your temporary password is:{tempPassword}";
                client.Send(mail);   

            }
        }
    }
}

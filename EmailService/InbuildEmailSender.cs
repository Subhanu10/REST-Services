using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailService
{
    public class InbuildEmailSender
    {

        string gmailAppPassword = "ggsb tuff qeyz umkp";
        string fromAddress = "subhanuvelusamy@gmail.com";
        string toAddress = "subhanu2719@gmail.com";
        string subject = "Default ";
        string content = "Default Content ";
        
        public InbuildEmailSender(string FromEmail, string Password, string ToEmail, string Subject, string Content )
        {
            fromAddress = FromEmail;
            gmailAppPassword = Password;
            toAddress = ToEmail;
            subject = Subject;
            content = Content;
        
        }
        public void SendEmail()
        {
            

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(fromAddress);
                    mail.To.Add(toAddress);
                    mail.Subject = subject;
                    mail.Body = content;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)) 
                    {
                        smtp.Credentials = new NetworkCredential(fromAddress, gmailAppPassword);
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Send(mail);
                        Console.WriteLine("Email sent successfully!");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to send email:" + ex.Message);
            }
        }
    }
}

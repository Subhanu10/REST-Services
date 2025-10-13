using System;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailService
{
    public class MailKitEmailSender
    {
        public void SendEmailAsync()
        {

            string gmailAppPassword = "ggsbtuffqeyzumkp";
            string fromAddress = "subhanuvelusamy@gmail.com";
            string toAddress = "subhanu2719@gmail.com";

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("subhanuvelusamy", fromAddress));
            email.To.Add(new MailboxAddress("subhanu", toAddress));
            email.Subject = "Test Email from New";
            email.Body = new TextPart("Plain")
            {
                Text = "This is a text email send using Mailkit."
            };


            try
            {
                using (var smtp = new SmtpClient())
                {

                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate(fromAddress, gmailAppPassword);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                    Console.WriteLine("Email sent successfully!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email:");
            }
        }
    }
}





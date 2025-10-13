using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_Services.Models;
using System.Net.Mail;
using System.Net;
using EmailService;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
       

        // POST api/<EmailController>
        [HttpPost]
        public string SendEmail(EmailItem model)
        {
            try
            {
                EmailItem Message = new EmailItem();
                Message.FromEmail = model.FromEmail;
                Message.Password = model.Password;
                Message.ToEmail = model.ToEmail;
                Message.Subject = model.Subject;
                Message.Content = model.Content;

                InbuildEmailSender obj = new InbuildEmailSender();
                obj.SendEmail();



                return ("Email sent successfully!");
            }
            catch(Exception ex)
            {
                return "Error";   
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Services.Models
{
    public class EmailItem
    {
        public string FromEmail { get; set; }
        public string Password { get; set; }
        public string ToEmail { get; set;}
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Services.Models
{
    public class LoginItems
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
        public List<string> Skills { get; set; }
        public DateTime Date { get; set; }
    }
}

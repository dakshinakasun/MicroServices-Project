using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.WebApp.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}

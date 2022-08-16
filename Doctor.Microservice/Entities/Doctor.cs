using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor.Microservice.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Spec_Type { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
    }
}

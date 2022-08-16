using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prescription.Microservice.Entities
{
    public class Prescription : BaseEntity
    {
        public int Doc_Id { get; set; }
        public int Pat_Id { get; set; }
        public int Med_Id { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
    }
}

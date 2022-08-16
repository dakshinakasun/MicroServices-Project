using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Microservice.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Pat_Id { get; set; }
    }
}

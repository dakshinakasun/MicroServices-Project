using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor.Microservice.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Doc_Id { get; set; }
    }
}

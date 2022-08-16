using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.Microservice.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Med_Id { get; set; }
    }
}

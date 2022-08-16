using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Patient> Patients { get; set; }
        Task<int> SaveAppChanges();
    }
}

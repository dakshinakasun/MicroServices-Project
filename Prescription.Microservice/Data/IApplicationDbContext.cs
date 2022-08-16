using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prescription.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Prescription> Prescriptions { get; set; }
        Task<int> SaveAppChanges();
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Doctor> Doctors { get; set; }
        Task<int> SaveAppChanges();
    }
}

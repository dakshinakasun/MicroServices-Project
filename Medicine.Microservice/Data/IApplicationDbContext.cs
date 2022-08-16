using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Medicine> Medicines { get; set; }
        Task<int> SaveAppChanges();
    }
}

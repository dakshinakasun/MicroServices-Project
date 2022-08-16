using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prescription.Microservice.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Entities.Prescription> Prescriptions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public async Task<int> SaveAppChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Prescription>().HasData(
                new Entities.Prescription()
                { Prs_Id = 1, Doc_Id = 1, Pat_Id = 2, Med_Id = 2, Quantity = 18, Date = "05-06-2022"},
                new Entities.Prescription()
                { Prs_Id = 2, Doc_Id = 2, Pat_Id = 3, Med_Id = 1, Quantity = 27, Date = "10-06-2022"},
                new Entities.Prescription()
                { Prs_Id = 3, Doc_Id = 3, Pat_Id = 1, Med_Id = 3, Quantity = 15, Date = "07-06-2022"});
        }
    }
}

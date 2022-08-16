using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Microservice.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Entities.Patient> Patients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public async Task<int> SaveAppChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Patient>().HasData(
                new Entities.Patient()
                { Pat_Id = 1, Name = "Mr.Kamal Suraweera", Gender = "Male", Age = 35, Contact_No = "0761234567", Email = "kamal@gmail.com", Address = "Kaluthara" },
                new Entities.Patient()
                { Pat_Id = 2, Name = "Mr.Amal Fernando", Gender = "Male", Age = 28, Contact_No = "0711234567", Email = "fernando@gmail.com", Address = "Colombo" },
                new Entities.Patient()
                { Pat_Id = 3, Name = "Mr.Manuka Liyanage", Gender = "Male", Age = 30, Contact_No = "0771234567", Email = "manuka@gmail.com", Address = "Gampaha" });
        }
    }
}

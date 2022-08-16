using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor.Microservice.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Entities.Doctor> Doctors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public async Task<int> SaveAppChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Doctor>().HasData(
                new Entities.Doctor()
                { Doc_Id = 1, Name = "Dr.Dakshina Kasun", Age = 25, Gender = "Male", Spec_Type = "Cardiologists", Contact_No = "0761234567", Email = "kasun@gmail.com" },
                new Entities.Doctor()
                { Doc_Id = 2, Name = "Dr.Kaveen Akash", Age = 24, Gender = "Male", Spec_Type = "Allergists", Contact_No = "0711234567", Email = "akash@gmail.com" },
                new Entities.Doctor()
                { Doc_Id = 3, Name = "Dr.Deshani Dakshima", Age = 24, Gender = "Female", Spec_Type = "Neurologists", Contact_No = "0771234567", Email = "deshani@gmail.com" });
        }
    }
}

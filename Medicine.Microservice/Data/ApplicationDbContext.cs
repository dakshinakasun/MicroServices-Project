using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.Microservice.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Entities.Medicine> Medicines { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public async Task<int> SaveAppChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Medicine>().HasData(
                new Entities.Medicine()
                { Med_Id = 1, Name = "Amikacin", Badge = 9854145, Init_Quantity = 5000, Curr_Quantity = 2500, Exp_Date = "01-12-2025"},
                new Entities.Medicine()
                { Med_Id = 2, Name = "Crizotinib", Badge = 8424956, Init_Quantity = 5000, Curr_Quantity = 1000, Exp_Date = "01-12-2025" },
                new Entities.Medicine()
                { Med_Id = 3, Name = "Etoposid", Badge = 4594252, Init_Quantity = 5000, Curr_Quantity = 3280, Exp_Date = "01-12-2025" });
        }

    }
}

using Medicine.Microservice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medicine.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public MedicineController(IApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/<MedicineController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medicines = await this.context.Medicines.ToListAsync();
            if (medicines == null) return NotFound();
            return Ok(medicines);
        }

        // GET api/<MedicineController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medicines = await this.context.Medicines.Where(x => x.Med_Id == id).FirstOrDefaultAsync();
            if (medicines == null) return NotFound();
            return Ok(medicines);

        }

        // POST api/<MedicineController>
        [HttpPost]
        public async Task<IActionResult> Create(Entities.Medicine medicine)
        {
            this.context.Medicines.Add(medicine);
            await this.context.SaveAppChanges();
            return Ok(medicine.Med_Id);
        }

        // PUT api/<MedicineController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Entities.Medicine medicineData)
        {
            var medicine = await this.context.Medicines.Where(x => x.Med_Id == id).FirstOrDefaultAsync();
            if (medicine == null) return NotFound();
            else
            {
                medicine.Name = medicineData.Name;
                medicine.Badge = medicineData.Badge;
                medicine.Init_Quantity = medicineData.Init_Quantity;
                medicine.Curr_Quantity = medicineData.Curr_Quantity;
                medicine.Exp_Date = medicineData.Exp_Date;
                await this.context.SaveAppChanges();
                return Ok(medicine.Med_Id);
            }
        }

        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var medicines = await this.context.Medicines.Where(x => x.Med_Id == id).FirstOrDefaultAsync();
            if (medicines == null) return NotFound();
            this.context.Medicines.Remove(medicines);
            await this.context.SaveAppChanges();
            return Ok(medicines.Med_Id);
        }
    }
}

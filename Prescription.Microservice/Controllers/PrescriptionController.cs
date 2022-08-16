using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prescription.Microservice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prescription.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public PrescriptionController(IApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/<PrescriptionController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var prescriptions = await this.context.Prescriptions.ToListAsync();
            if (prescriptions == null) return NotFound();
            return Ok(prescriptions);
        }

        // GET api/<PrescriptionController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var prescriptions = await this.context.Prescriptions.Where(x => x.Prs_Id == id).FirstOrDefaultAsync();
            if (prescriptions == null) return NotFound();
            return Ok(prescriptions);

        }

        // POST api/<PrescriptionController>
        [HttpPost]
        public async Task<IActionResult> Create(Entities.Prescription prescription)
        {
            this.context.Prescriptions.Add(prescription);
            await this.context.SaveAppChanges();
            return Ok(prescription.Prs_Id);
        }

        // PUT api/<PrescriptionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Entities.Prescription prescriptionData)
        {
            var prescription = await this.context.Prescriptions.Where(x => x.Prs_Id == id).FirstOrDefaultAsync();
            if (prescription == null) return NotFound();
            else
            {
                prescription.Doc_Id = prescriptionData.Doc_Id;
                prescription.Pat_Id = prescriptionData.Pat_Id;
                prescription.Med_Id = prescriptionData.Med_Id;
                prescription.Quantity = prescriptionData.Quantity;
                prescription.Date = prescriptionData.Date;
                await this.context.SaveAppChanges();
                return Ok(prescription.Prs_Id);
            }
        }

        // DELETE api/<PrescriptionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var prescription = await this.context.Prescriptions.Where(x => x.Prs_Id == id).FirstOrDefaultAsync();
            if (prescription == null) return NotFound();
            this.context.Prescriptions.Remove(prescription);
            await this.context.SaveAppChanges();
            return Ok(prescription.Prs_Id);
        }
    }
}

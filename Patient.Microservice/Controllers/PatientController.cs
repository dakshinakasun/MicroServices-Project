using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient.Microservice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public PatientController(IApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/<PatientController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await this.context.Patients.ToListAsync();
            if (patients == null) return NotFound();
            return Ok(patients);
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == 0) return NotFound();
            var patients = await this.context.Patients.Where(x => x.Pat_Id == id).FirstOrDefaultAsync();
            if (patients == null) return NotFound();
            return Ok(patients);
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task<IActionResult> Create(Entities.Patient patient)
        {
            this.context.Patients.Add(patient);
            await this.context.SaveAppChanges();
            return Ok(patient.Pat_Id);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Entities.Patient patientData)
        {
            var patient = await this.context.Patients.Where(x => x.Pat_Id == id).FirstOrDefaultAsync();
            if (patient == null) return NotFound();
            else
            {
                patient.Name = patientData.Name;
                patient.Gender = patientData.Gender;
                patient.Age = patientData.Age;
                patient.Contact_No = patientData.Contact_No;
                patient.Email = patientData.Email;
                patient.Address = patientData.Address;
                await this.context.SaveAppChanges();
                return Ok(patient.Pat_Id);
            }
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0) return NotFound();
            var patient = await this.context.Patients.Where(x => x.Pat_Id == id).FirstOrDefaultAsync();
            if (patient == null) return NotFound();
            this.context.Patients.Remove(patient);
            await this.context.SaveAppChanges();
            return Ok(patient.Pat_Id);
        }
    }
}

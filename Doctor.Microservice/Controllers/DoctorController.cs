using Doctor.Microservice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Doctor.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public DoctorController(IApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/<DoctorController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await this.context.Doctors.ToListAsync();
            if (doctors == null) return NotFound();
            return Ok(doctors);
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var doctors = await this.context.Doctors.Where(x => x.Doc_Id == id).FirstOrDefaultAsync();
            if (doctors == null) return NotFound();
            return Ok(doctors);

        }

        // POST api/<DoctorController>
        [HttpPost]
        public async Task<IActionResult> Create(Entities.Doctor doctor)
        {
            this.context.Doctors.Add(doctor);
            await this.context.SaveAppChanges();
            return Ok(doctor.Doc_Id);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Entities.Doctor doctorData)
        {
            var doctor = await this.context.Doctors.Where(x => x.Doc_Id == id).FirstOrDefaultAsync();
            if (doctor == null) return NotFound();
            else
            {
                doctor.Name = doctorData.Name;
                doctor.Age = doctorData.Age;
                doctor.Gender = doctorData.Gender;
                doctor.Spec_Type = doctorData.Spec_Type;
                doctor.Contact_No = doctorData.Contact_No;
                doctor.Email = doctorData.Email;
                await this.context.SaveAppChanges();
                return Ok(doctor.Doc_Id);
            }
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var doctor = await this.context.Doctors.Where(x => x.Doc_Id == id).FirstOrDefaultAsync();
            if (doctor == null) return NotFound();
            this.context.Doctors.Remove(doctor);
            await this.context.SaveAppChanges();
            return Ok(doctor.Doc_Id);
        }
    }
}

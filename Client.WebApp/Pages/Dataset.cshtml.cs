using Client.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Client.WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Called when [get].
        /// </summary>
        public async Task OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;

            List<string> DocList = await GetDoctorsList();
            ViewData["DoctorsList"] = DocList;

            List<string> PatList = await GetPatientsList();
            ViewData["PatientsList"] = PatList;

            List<string> MedList = await GetMedicinesList();
            ViewData["MedicinesList"] = MedList;

            List<string> PreList = await GetPrescriptionsList();
            ViewData["PrescriptionsList"] = PreList;
        }


        /// <summary>
        /// Gets the temperature list in celsius.
        /// </summary>
        /// <returns></returns>
        private async Task<List<string>> GetDoctorsList()
        {
            List<string> DocList = new List<string>();
            List<Doctor> serviceResponse = await ServicesInvoker.GetDoctorsList();
            foreach (var item in serviceResponse)
            {
                DocList.Add(item.Name.ToString());
            }
            return DocList;
        }

        private async Task<List<string>> GetPatientsList()
        {
            List<string> PatList = new List<string>();
            List<Patient> serviceResponse = await ServicesInvoker.GetPatientsList();
            foreach (var item in serviceResponse)
            {
                PatList.Add(item.Name.ToString());
            }
            return PatList;
        }

        private async Task<List<string>> GetMedicinesList()
        {
            List<string> MedList = new List<string>();
            List<Medicine> serviceResponse = await ServicesInvoker.GetMedicinesList();
            foreach (var item in serviceResponse)
            {
                MedList.Add(item.Name.ToString());
            }
            return MedList;
        }

        private async Task<List<string>> GetPrescriptionsList()
        {
            List<string> PreList = new List<string>();
            List<Prescription> serviceResponse = await ServicesInvoker.GetPrescriptionsList();
            foreach (var item in serviceResponse)
            {
                PreList.Add(item.Doc_Id.ToString());
            }

            return PreList;
          
        }

    }
}

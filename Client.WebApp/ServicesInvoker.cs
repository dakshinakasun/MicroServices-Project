using Client.WebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client.WebApp
{
    public class ServicesInvoker
    {
        private static readonly HttpClient client = new HttpClient();

        protected ServicesInvoker()
        {

        }

        /// <summary>
        /// Gets the weather forcast details.
        /// </summary>
        /// <returns></returns>
        public async static Task<List<Doctor>> GetDoctorsList()
        {
            List<Doctor> doctorList = new();
            Uri uri = new Uri("https://localhost:44383/gateway/doctor");

            var response = await client.GetAsync(uri);
            var rowresponse = response.Content.ReadAsStringAsync();
            doctorList = JsonConvert.DeserializeObject<List<Doctor>>(rowresponse.Result.ToString());

            return doctorList;

        }

        public async static Task<List<Patient>> GetPatientsList()
        {
            List<Patient> patientList = new();
            Uri uri = new Uri("https://localhost:44383/gateway/patient");

            var response = await client.GetAsync(uri);
            var rowresponse = response.Content.ReadAsStringAsync();
            patientList = JsonConvert.DeserializeObject<List<Patient>>(rowresponse.Result.ToString());

            return patientList;

        }

        public async static Task<List<Medicine>> GetMedicinesList()
        {
            List<Medicine> medicineList = new();
            Uri uri = new Uri("https://localhost:44383/gateway/medicine");

            var response = await client.GetAsync(uri);
            var rowresponse = response.Content.ReadAsStringAsync();
            medicineList = JsonConvert.DeserializeObject<List<Medicine>>(rowresponse.Result.ToString());

            return medicineList;

        }

        public async static Task<List<Prescription>> GetPrescriptionsList()
        {
            List<Prescription> prescriptionList = new();
            Uri uri = new Uri("https://localhost:44383/gateway/prescription");

            var response = await client.GetAsync(uri);
            var rowresponse = response.Content.ReadAsStringAsync();
            prescriptionList = JsonConvert.DeserializeObject<List<Prescription>>(rowresponse.Result.ToString());

            return prescriptionList;

        }
    }
}

using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Patient.Data;
using Sliit.MTIT.Patient.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService ?? throw new ArgumentNullException(nameof(patientService));
        }


        /// <summary>
        /// Get all patients
        /// </summary>
        /// <returns>return the list of  patients</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_patientService.GetPatients());
        }

        /// <summary>
        /// Get  patient by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the  patient with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _patientService.GetPatient(id) != null ? Ok(_patientService.GetPatient(id)) : NoContent();
        }

        /// <summary>
        /// Add  patients
        /// </summary>
        /// <param name=" patient"></param>
        /// <returns>Return the added  patient</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Patient patient)
        {
            return Ok(_patientService.AddPatient(patient));
        }

        /// <summary>
        /// Update the patient
        /// </summary>
        /// <param name=" patient"></param>
        /// <returns>Return the updated  patient</returns>>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Patient patient)
        {
            return Ok(_patientService.UpdatePatient(patient));
        }

        /// <summary>
        /// Delete the  patient with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _patientService.DeletePatient(id);

            return result.HasValue & result == true ? Ok($"patient with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the patient with ID:{id}.");
        }
    }
}

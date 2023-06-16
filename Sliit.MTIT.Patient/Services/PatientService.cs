using Sliit.MTIT.Patient.Data;
using Sliit.MTIT.Patient.Models;

namespace Sliit.MTIT.Patient.Services
{
    public class PatientService:IPatientService
    {
        public List<Models.Patient> GetPatients()
        {
            return PatientMockDataService.Patients;
        }

        public Models.Patient? GetPatient(int id)
        {
            return PatientMockDataService.Patients.FirstOrDefault(x => x.Id == id);
        }

        public Models.Patient? AddPatient(Models.Patient patient)
        {
            PatientMockDataService.Patients.Add(patient);
            return patient;
        }

        public Models.Patient? UpdatePatient(Models.Patient patient)
        {
            Models.Patient selectedPatient = PatientMockDataService.Patients.FirstOrDefault(x => x.Id == patient.Id);
            if (selectedPatient != null)
            {
                selectedPatient.Address = patient.Address;
                selectedPatient.Age = patient.Age;
                selectedPatient.Name = patient.Name;
                return selectedPatient;
            }

            return selectedPatient;
        }

        public bool? DeletePatient(int id)
        {
            Models.Patient selectedPatient = PatientMockDataService.Patients.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                PatientMockDataService.Patients.Remove(selectedPatient);
                return true;
            }
            return false;
        }
    }
}

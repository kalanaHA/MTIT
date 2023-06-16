namespace Sliit.MTIT.Patient.Data
{
    public static class PatientMockDataService
    {
        public static List<Models.Patient> Patients = new List<Models.Patient>()
        {
            new Models.Patient { Id = 1, Name = "Kalana", Address = "12 Kiribathgoda", Age = 20, Telephone = 0710141243, Illness = "Headaches" },
            new Models.Patient { Id = 2, Name = "Vindya", Address = "56 Kegalle", Age = 22, Telephone = 071438796, Illness = "Allergies" },
            new Models.Patient { Id = 3, Name = "Eshan", Address = "78 Rathnapura", Age = 21, Telephone = 0716578905, Illness = "Stomach Aches" },
            new Models.Patient { Id = 4, Name = "Yomal", Address = "32 Kadawatha", Age = 23, Telephone = 0713654488, Illness = "Mononucleosis" },
            new Models.Patient { Id = 5, Name = "Ravindu", Address = "65 Gampaha", Age = 19, Telephone = 0714195023, Illness = "Conjunctivitis" }
        };

    }
}

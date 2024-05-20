namespace HealthcareAPI.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}

namespace HealthcareAPI.Models
{
    public class Doctor : Person
    {
        public int Id { get; set; }
        public string Specialty { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}

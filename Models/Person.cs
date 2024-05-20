namespace HealthcareAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Occupation Occupation { get; set; }

        public Address Address1 { get; set; }
    }
}

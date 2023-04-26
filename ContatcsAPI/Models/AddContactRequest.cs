namespace ContatcsAPI.Models
{
    public class AddContactRequest
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContatcsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }

       [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? Address { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? City { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Country { get; set; }
    }
}

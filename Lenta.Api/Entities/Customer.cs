using System.ComponentModel.DataAnnotations;

namespace Lenta.Api.Entities
{
    public class Customer : Entity
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}

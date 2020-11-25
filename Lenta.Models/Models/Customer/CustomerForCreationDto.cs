using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lenta.Shared.Models.Customer
{
    public class CustomerForCreationDto
    {
        [Required(ErrorMessage = "Prašome įvesti vardą")]
        [MaxLength(50, ErrorMessage = "Vardas turi neviršyti 50 simbolių")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Prašome įvesti pavardę")]
        [MaxLength(50, ErrorMessage = "Pavardė turi neviršyti 50 simbolių")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Prašome įvesti telefono numerį")]
        [Phone(ErrorMessage = "Prašome įvesti teisingą telefono numerį")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Prašome įvesti elektroninį paštą")]
        [EmailAddress(ErrorMessage = "Prašome įvesti teisingą elektroninį paštą")]
        public string Email { get; set; }
    }
}

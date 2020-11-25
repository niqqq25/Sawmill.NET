using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.Product
{
    public class CustomProductForCreationDto
    {
        [Required(ErrorMessage = "Prašome įvesti pavadinimą")]
        [MaxLength(50, ErrorMessage = "Pavadinimas turi neviršyti 50 simbolių")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Aprašymas turi neviršyti 100 simbolių")]
        public string Description { get; set; }
    }
}

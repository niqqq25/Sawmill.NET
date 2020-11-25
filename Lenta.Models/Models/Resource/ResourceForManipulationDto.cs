using Lenta.Shared.Types;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.Resource
{
    public abstract class ResourceForManipulationDto
    {
        [Required(ErrorMessage = "Prašome įvesti pavadinimą")]
        [MaxLength(50, ErrorMessage = "Pavadinimas turi neviršyti 50 simbolių")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Aprašymas turi neviršyti 100 simbolių")]
        public string Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Kiekis turi būti didesnis arba lygus 0")]
        public float Quantity { get; set; }
        [Required(ErrorMessage = "Prašome pasirinkti Kiekio Tipą")]
        public Units QuantityType { get; set; }
    }
}

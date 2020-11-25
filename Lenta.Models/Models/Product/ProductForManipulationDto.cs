using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.Product
{
    public class ProductForManipulationDto
    {
        [Required(ErrorMessage = "Prašome įvesti pavadinimą")]
        [MaxLength(50, ErrorMessage = "Pavadinimas turi neviršyti 50 simbolių")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Aprašymas turi neviršyti 100 simbolių")]
        public string Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Esamas kiekis turi būti didesnis arba lygus 0")]
        public int UnitsInStock { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Užsakytas kiekis turi būti didesnis arba lygus 0")]
        public int UnitsOnOrder { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Vieneto kaina turi būti didesnė arba lygi 0")]
        public decimal UnitPrice { get; set; }
    }
}

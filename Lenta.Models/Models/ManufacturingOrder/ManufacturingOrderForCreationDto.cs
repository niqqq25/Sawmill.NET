using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.ManufacturingOrder
{
    public class ManufacturingOrderForCreationDto
    {
        [Required(ErrorMessage = "Prašome pasirinkti prekę")]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Užsakomas kiekis turi būti didesnis arba lygus 1")]
        public int Quantity { get; set; }
    }
}

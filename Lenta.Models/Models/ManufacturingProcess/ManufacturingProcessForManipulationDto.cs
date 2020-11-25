using Lenta.Shared.Types;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.ManufacturingProcess
{
    public class ManufacturingProcessForManipulationDto
    {
        [Required(ErrorMessage = "Prašome įvesti pavadinimą")]
        [MaxLength(50, ErrorMessage = "Pavadinimas turi neviršyti 50 simbolių")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Aprašymas turi neviršyti 50 simbolių")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Prašome pasirinkti proceso būseną")]
        public ManufacturingProcessStatus Status { get; set; }
    }
}
using Lenta.Shared.Types;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.ManufacturingOrder
{
    public class ManufacturingOrderForUpdateDto
    {
        [Required]
        public ManufacturingOrderStatus Status { get; set; }
    }
}

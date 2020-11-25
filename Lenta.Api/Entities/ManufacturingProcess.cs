using Lenta.Shared.Types;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Api.Entities
{
    public class ManufacturingProcess : Entity
    {
        public ManufacturingProcess()
        {
            Status = ManufacturingProcessStatus.Neaktyvus;
        }

        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public ManufacturingProcessStatus Status { get; set; }
    }
}

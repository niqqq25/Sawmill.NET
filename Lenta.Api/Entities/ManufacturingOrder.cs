using Lenta.Shared.Types;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Api.Entities
{
    public class ManufacturingOrder : Entity
    {
        public ManufacturingOrder()
        {
            Status = ManufacturingOrderStatus.Vykdomas;
            OrderDate = DateTimeOffset.Now;
        }

        [Required]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        public ManufacturingOrderStatus Status { get; set; }
        [Required]
        public DateTimeOffset OrderDate { get; set; }

        public Product Product { get; set; }
    }
}

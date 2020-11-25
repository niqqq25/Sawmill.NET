using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lenta.Api.Entities
{
    public class CustomerOrderItem : Entity
    {
        [Required]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(1, double.MaxValue)]
        public decimal UnitPrice { get; set; }
        [ForeignKey("Order"), Required]
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public CustomerOrder Order { get; set; }
    }
}

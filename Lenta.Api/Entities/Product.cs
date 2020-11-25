using Lenta.Shared.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lenta.Api.Entities
{
    public class Product : Entity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Range(0, int.MaxValue)]
        public int UnitsInStock { get; set; }
        [Range(0, int.MaxValue)]
        public int UnitsOnOrder { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue)]
        public decimal UnitPrice { get; set; }
        [Required]
        public ProductType Type { get; set; }

        public List<ManufacturingOrder> ManufacturingOrders { get; set; } = new List<ManufacturingOrder>();
        public List<CustomerOrderItem> CustomerOrderItems { get; set; }
    }
}

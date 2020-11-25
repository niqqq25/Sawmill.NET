using Lenta.Shared.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lenta.Shared.Models.CustomerOrderItem
{
    public class CustomerOrderItemForCreationDto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Užsakomas kiekis turi būti didesnis arba lygus 1")]
        public int Quantity { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vieneto kaina turi būti didesnė arba lygi 1")]
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
        [ValidateComplexType]
        public CustomProductForCreationDto Product { get; set; } = new CustomProductForCreationDto();
    }
}

using Lenta.Shared.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lenta.Shared.Models.CustomerOrderItem
{
    public class CustomerOrderItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public ProductDto Product { get; set; }
    }
}

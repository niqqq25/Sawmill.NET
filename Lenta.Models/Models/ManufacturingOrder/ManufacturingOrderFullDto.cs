using Lenta.Shared.Models.Product;
using Lenta.Shared.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lenta.Shared.Models.ManufacturingOrder
{
    public class ManufacturingOrderFullDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public ManufacturingOrderStatus Status { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public CustomProductDto Product { get; set; }
    }
}

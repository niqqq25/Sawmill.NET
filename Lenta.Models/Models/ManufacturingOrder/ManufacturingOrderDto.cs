using Lenta.Shared.Types;
using System;

namespace Lenta.Shared.Models.ManufacturingOrder
{
    public class ManufacturingOrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ManufacturingOrderStatus Status { get; set; }
        public DateTimeOffset OrderDate { get; set; }
    }
}

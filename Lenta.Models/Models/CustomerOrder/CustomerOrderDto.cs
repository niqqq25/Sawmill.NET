using Lenta.Shared.Types;
using System;

namespace Lenta.Shared.Models.CustomerOrder
{
    public class CustomerOrderDto
    {
        public int Id { get; set; }
        public CustomerOrderStatus Status { get; set; }
        public DateTimeOffset OrderDate { get; set; }
    }
}

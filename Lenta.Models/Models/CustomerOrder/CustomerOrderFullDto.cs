using Lenta.Shared.Models.Customer;
using Lenta.Shared.Models.CustomerOrderItem;
using Lenta.Shared.Types;
using System;
using System.Collections.Generic;

namespace Lenta.Shared.Models.CustomerOrder
{
    public class CustomerOrderFullDto
    {
        public int Id { get; set; }
        public CustomerOrderStatus Status { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public CustomerDto Customer { get; set; }
        public List<CustomerOrderItemDto> OrderItems { get; set; }
    }
}

using Lenta.Shared.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Api.Entities
{
    public class CustomerOrder : Entity
    {
        public CustomerOrder()
        {
            OrderDate = DateTimeOffset.Now;
        }

        [Required]
        public int CustomerId { get; set; }
        [Required]
        public CustomerOrderStatus Status { get; set; }
        [Required]
        public DateTimeOffset OrderDate { get; set; }

        public Customer Customer { get; set; }
        public List<CustomerOrderItem> OrderItems { get; set; }
    }
}

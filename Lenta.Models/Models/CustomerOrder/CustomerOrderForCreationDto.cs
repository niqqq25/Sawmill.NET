using Lenta.Shared.Models.Customer;
using Lenta.Shared.Models.CustomerOrderItem;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.CustomerOrder
{
    public class CustomerOrderForCreationDto
    {
        [Required]
        [ValidateComplexType]
        public CustomerForCreationDto Customer { get; set; }
        [Required]
        [ValidateComplexType]
        public List<CustomerOrderItemForCreationDto> OrderItems { get; set; } = new List<CustomerOrderItemForCreationDto>();
    }
}
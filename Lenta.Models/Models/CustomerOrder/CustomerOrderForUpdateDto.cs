using Lenta.Shared.Types;
using System.ComponentModel.DataAnnotations;

namespace Lenta.Shared.Models.CustomerOrder
{
    public class CustomerOrderForUpdateDto
    {
        [Required]
        public CustomerOrderStatus Status { get; set; }
    }
}

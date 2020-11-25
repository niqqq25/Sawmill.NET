using Lenta.Shared.Models.CustomerOrder;
using Lenta.Shared.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public interface ICustomerOrderService
    {
        Task<PagedResponse<List<CustomerOrderDto>>> GetOrders(string query);
        Task<Response<CustomerOrderFullDto>> GetOrder(string id);
        Task<CustomerOrderFullDto> CreateOrder(CustomerOrderForCreationDto order);
        Task<Response<CustomerOrderFullDto>> EditOrder(string id, CustomerOrderForUpdateDto order);
    }
}

using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Shared.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public interface IManufacturingOrderService
    {
        Task<PagedResponse<List<ManufacturingOrderDto>>> GetOrders(string query);
        Task<Response<ManufacturingOrderFullDto>> GetOrder(string id);
        Task<ManufacturingOrderDto> CreateOrder(ManufacturingOrderForCreationDto order);
        Task<Response<ManufacturingOrderFullDto>> EditOrder(string id, ManufacturingOrderForUpdateDto order);
    }
}

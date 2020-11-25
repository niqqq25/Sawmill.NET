using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public class ManufacturingOrderService : IManufacturingOrderService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;

        public ManufacturingOrderService(HttpClient httpClient, NavigationManager navigationManager)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
        }

        public async Task<ManufacturingOrderDto> CreateOrder(ManufacturingOrderForCreationDto order)
        {
            try
            {
                return await httpClient.PostJsonAsync<ManufacturingOrderDto>("api/manufacturingorders", order);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<ManufacturingOrderFullDto>> EditOrder(string id, ManufacturingOrderForUpdateDto order)
        {
            try
            {
                return await httpClient.PutJsonAsync<Response<ManufacturingOrderFullDto>>("api/manufacturingorders/" + id, order);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<ManufacturingOrderFullDto>> GetOrder(string id)
        {
            try
            {
                return await httpClient.GetJsonAsync<Response<ManufacturingOrderFullDto>>("api/manufacturingorders/" + id);
            }
            catch
            {
                navigationManager.NavigateTo("/error");
                return null;
            }
        }

        public async Task<PagedResponse<List<ManufacturingOrderDto>>> GetOrders(string query)
        {
            return await httpClient.GetJsonAsync<PagedResponse<List<ManufacturingOrderDto>>>("api/manufacturingorders" + query);
        }
    }
}

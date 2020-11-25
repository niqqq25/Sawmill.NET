using Lenta.Shared.Models.CustomerOrder;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public class CustomerOrderService : ICustomerOrderService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;

        public CustomerOrderService(HttpClient httpClient, NavigationManager navigationManager)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
        }

        public async Task<CustomerOrderFullDto> CreateOrder(CustomerOrderForCreationDto order)
        {
            try
            {
                return await httpClient.PostJsonAsync<CustomerOrderFullDto>("api/customerorders", order);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<CustomerOrderFullDto>> EditOrder(string id, CustomerOrderForUpdateDto order)
        {
            try
            {
                return await httpClient.PutJsonAsync<Response<CustomerOrderFullDto>>("api/customerorders/" + id, order);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<CustomerOrderFullDto>> GetOrder(string id)
        {
            try
            {
                return await httpClient.GetJsonAsync<Response<CustomerOrderFullDto>>("api/customerorders/" + id);
            }
            catch
            {
                navigationManager.NavigateTo("/error");
                return null;
            }
        }

        public async Task<PagedResponse<List<CustomerOrderDto>>> GetOrders(string query)
        {
            return await httpClient.GetJsonAsync<PagedResponse<List<CustomerOrderDto>>>("api/customerorders" + query);
        }
    }
}

using Lenta.Shared.Models.Product;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;

        public ProductService(HttpClient httpClient, NavigationManager navigationManager)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
        }

        public async Task<ProductDto> CreateProduct(ProductForCreationDto product)
        {
            try
            {
                return await httpClient.PostJsonAsync<ProductDto>("api/products", product);
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> DeleteProduct(string id)
        {
            return await httpClient.DeleteAsync("api/products/" + id);
        }

        public async Task<Response<ProductDto>> EditProduct(string id, ProductForUpdateDto product)
        {
            try
            {
                return await httpClient.PutJsonAsync<Response<ProductDto>>("api/products/" + id, product);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<ProductDto>> GetProduct(string id)
        {
            try
            {
                return await httpClient.GetJsonAsync<Response<ProductDto>>("api/products/" + id);
            } catch
            {
                navigationManager.NavigateTo("/error");
                return null;
            }
        }

        public async Task<PagedResponse<List<ProductDto>>> GetProducts(string query)
        {
            return await httpClient.GetJsonAsync<PagedResponse<List<ProductDto>>>("api/products" + query);
        }
    }
}

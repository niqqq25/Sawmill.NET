using Lenta.Shared.Models.Product;
using Lenta.Shared.Wrappers;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public interface IProductService
    {
        Task<PagedResponse<List<ProductDto>>> GetProducts(string query);
        Task<Response<ProductDto>> GetProduct(string id);
        Task<ProductDto> CreateProduct(ProductForCreationDto product);
        Task<Response<ProductDto>> EditProduct(string id, ProductForUpdateDto product);
        Task<HttpResponseMessage> DeleteProduct(string id);
    }
}

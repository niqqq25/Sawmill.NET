using Lenta.Shared.Models.Resource;
using Lenta.Shared.Wrappers;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public interface IResourceService
    {
        Task<PagedResponse<List<ResourceDto>>> GetResources(string query);
        Task<Response<ResourceDto>> GetResource(string id);
        Task<ResourceDto> CreateResource(ResourceForCreationDto resource);
        Task<Response<ResourceDto>> EditResource(string id, ResourceForUpdateDto resource);
        Task<HttpResponseMessage> DeleteResource(string id);
    }
}

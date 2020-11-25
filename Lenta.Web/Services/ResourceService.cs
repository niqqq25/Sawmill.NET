using Lenta.Shared.Models.Resource;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public class ResourceService : IResourceService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;

        public ResourceService(HttpClient httpClient, NavigationManager navigationManager)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
        }

        public async Task<ResourceDto> CreateResource(ResourceForCreationDto resource)
        {
            try
            {
                return await httpClient.PostJsonAsync<ResourceDto>("api/resources", resource);
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> DeleteResource(string id)
        {
            return await httpClient.DeleteAsync("api/resources/" + id);
        }

        public async Task<Response<ResourceDto>> EditResource(string id, ResourceForUpdateDto resource)
        {
            try
            {
                return await httpClient.PutJsonAsync<Response<ResourceDto>>("api/resources/" + id, resource);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<ResourceDto>> GetResource(string id)
        {
            try
            {
                return await httpClient.GetJsonAsync<Response<ResourceDto>>("api/resources/" + id);
            }
            catch
            {
                navigationManager.NavigateTo("/error");
                return null;
            }
        }

        public async Task<PagedResponse<List<ResourceDto>>> GetResources(string query)
        {
            return await httpClient.GetJsonAsync<PagedResponse<List<ResourceDto>>>("api/resources" + query);
        }
    }
}
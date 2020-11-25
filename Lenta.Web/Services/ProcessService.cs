using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public class ProcessService : IProcessService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;

        public ProcessService(HttpClient httpClient, NavigationManager navigationManager)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
        }
        public async Task<ManufacturingProcessDto> CreateProcess(ManufacturingProcessForCreationDto process)
        {
            try
            {
                return await httpClient.PostJsonAsync<ManufacturingProcessDto>("api/processes", process);
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> DeleteProcess(string id)
        {
            return await httpClient.DeleteAsync("api/processes/" + id);
        }

        public async Task<Response<ManufacturingProcessDto>> EditProcess(string id, ManufacturingProcessForUpdateDto process)
        {
            try
            {
                return await httpClient.PutJsonAsync<Response<ManufacturingProcessDto>>("api/processes/" + id, process);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Response<ManufacturingProcessDto>> GetProcess(string id)
        {
            try
            {
                return await httpClient.GetJsonAsync<Response<ManufacturingProcessDto>>("api/processes/" + id);
            }
            catch
            {
                navigationManager.NavigateTo("/error");
                return null;
            }
        }

        public async Task<PagedResponse<List<ManufacturingProcessDto>>> GetProcesses(string query)
        {
            return await httpClient.GetJsonAsync<PagedResponse<List<ManufacturingProcessDto>>>("api/processes" + query);
        }
    }
}

using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Wrappers;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lenta.Web.Services
{
    public interface IProcessService
    {
        Task<PagedResponse<List<ManufacturingProcessDto>>> GetProcesses(string query);
        Task<Response<ManufacturingProcessDto>> GetProcess(string id);
        Task<ManufacturingProcessDto> CreateProcess(ManufacturingProcessForCreationDto process);
        Task<Response<ManufacturingProcessDto>> EditProcess(string id, ManufacturingProcessForUpdateDto process);
        Task<HttpResponseMessage> DeleteProcess(string id);
    }
}

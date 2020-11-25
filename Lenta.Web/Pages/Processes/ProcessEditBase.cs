using AutoMapper;
using Blazored.Toast.Services;
using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Processes
{
    public class ProcessEditBase : ComponentBase
    {
        [Inject]
        public IProcessService ProcessService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected ManufacturingProcessForUpdateDto Process { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Response<ManufacturingProcessDto> response = await ProcessService.GetProcess(Id);
            Process = Mapper.Map<ManufacturingProcessForUpdateDto>(response.Data);
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ProcessService.EditProcess(Id, Process);
            if (result != null)
            {
                ToastService.ShowSuccess($"Gamybos procesas '{Process.Name}' yra sėkmnigai atnaujintas");
                NavigationManager.NavigateTo("/processes");
            }
            else
            {
                ToastService.ShowError("Nepavyko atnaujinti gamybos proceso");
            }
        }
    }
}

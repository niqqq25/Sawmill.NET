using Blazored.Toast.Services;
using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Types;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Processes
{
    public class ProcessCreateBase : ComponentBase
    {
        [Inject]
        public IProcessService ProcessService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        protected ManufacturingProcessForCreationDto Process { get; set; }

        protected override void OnInitialized()
        {
            Process = new ManufacturingProcessForCreationDto()
            {
                Status = ManufacturingProcessStatus.Neaktyvus
            };
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ProcessService.CreateProcess(Process);
            if (result != null)
            {
                ToastService.ShowSuccess($"Gamybos procesas '{Process.Name}' yra sėkmingai sukurtas");
                NavigationManager.NavigateTo("/processes");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti gamybos proceso");
            }
        }
    }
}

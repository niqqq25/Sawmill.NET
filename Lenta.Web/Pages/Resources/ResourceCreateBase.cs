using Blazored.Toast.Services;
using Lenta.Shared.Models.Resource;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Resources
{
    public class ResourceCreateBase : ComponentBase
    {
        [Inject]
        public IResourceService ResourceService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        protected ResourceForCreationDto Resource { get; set; } = new ResourceForCreationDto();

        protected async Task HandleFormSubmit()
        {
            var result = await ResourceService.CreateResource(Resource);
            if (result != null)
            {
                ToastService.ShowSuccess($"Resursas '{Resource.Name}' yra sėkmingai sukurtas");
                NavigationManager.NavigateTo("/resources");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti resurso");
            }
        }
    }
}

using AutoMapper;
using Blazored.Toast.Services;
using Lenta.Shared.Models.Resource;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Resources
{
    public class ResourceEditBase : ComponentBase
    {
        [Inject]
        public IResourceService ResourceService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected ResourceForUpdateDto Resource { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Response<ResourceDto> response = await ResourceService.GetResource(Id);
            Resource = Mapper.Map<ResourceForUpdateDto>(response.Data);
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ResourceService.EditResource(Id, Resource);
            if (result != null)
            {
                ToastService.ShowSuccess($"Resursas '{Resource.Name}' yra sėkmnigai atnaujintas");
                NavigationManager.NavigateTo("/resources");
            }
            else
            {
                ToastService.ShowError("Nepavyko atnaujinti resurso");
            }
        }
    }
}

using Blazored.Toast.Services;
using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.ManufacturingOrders
{
    public class ManufacturingOrderEditBase : ComponentBase
    {
        [Inject]
        public IManufacturingOrderService ManufacturingOrderService { get; set; }
        public ManufacturingOrderFullDto Order { get; set; }
        public ManufacturingOrderForUpdateDto OrderUpdate { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public bool IsLoading { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            var result = await ManufacturingOrderService.GetOrder(Id);
            Order = result.Data;
            OrderUpdate = new ManufacturingOrderForUpdateDto()
            {
                Status = Order.Status
            };
            IsLoading = false;
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ManufacturingOrderService.EditOrder(Id, OrderUpdate);
            if (result != null)
            {
                ToastService.ShowSuccess($"Gamybos užsakyms '{Order.Product.Name}' yra sėkmnigai atnaujintas");
                NavigationManager.NavigateTo("/morders");
            }
            else
            {
                ToastService.ShowError("Nepavyko atnaujinti gamybos užsakymo");
            }
        }
    }
}

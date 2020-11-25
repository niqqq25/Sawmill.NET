using Blazored.Toast.Services;
using Lenta.Shared.Models.CustomerOrder;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Orders
{
    public class CustomerOrderEditBase : ComponentBase
    {
        [Inject]
        public ICustomerOrderService CustomerOrderService { get; set; }
        public CustomerOrderFullDto Order { get; set; }
        public CustomerOrderForUpdateDto OrderUpdate { get; set; }
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
            var result = await CustomerOrderService.GetOrder(Id);
            Order = result.Data;
            OrderUpdate = new CustomerOrderForUpdateDto()
            {
                Status = Order.Status
            };
            IsLoading = false;
        }

        protected async Task HandleFormSubmit()
        {
            var result = await CustomerOrderService.EditOrder(Id, OrderUpdate);
            if (result != null)
            {
                ToastService.ShowSuccess($"Gamybos užsakyms '{Order.Id}' yra sėkmnigai atnaujintas");
                NavigationManager.NavigateTo("/orders");
            }
            else
            {
                ToastService.ShowError("Nepavyko atnaujinti gamybos užsakymo");
            }
        }
    }
}

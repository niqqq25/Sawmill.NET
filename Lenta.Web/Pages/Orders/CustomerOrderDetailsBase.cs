using Lenta.Shared.Models.CustomerOrder;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Orders
{
    public class CustomerOrderDetailsBase : ComponentBase
    {
        [Inject]
        public ICustomerOrderService CustomerOrderService { get; set; }
        public CustomerOrderFullDto Order { get; set; }
        public bool IsLoading { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            var result = await CustomerOrderService.GetOrder(Id);
            Order = result.Data;
            IsLoading = false;
        }
    }
}

using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.ManufacturingOrders
{
    public class ManufacturingOrderDetailsBase : ComponentBase
    {
        [Inject]
        public IManufacturingOrderService ManufacturingOrderService { get; set; }
        public ManufacturingOrderFullDto Order { get; set; }
        public bool IsLoading { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            var result = await ManufacturingOrderService.GetOrder(Id);
            Order = result.Data;
            IsLoading = false;
        }
    }
}

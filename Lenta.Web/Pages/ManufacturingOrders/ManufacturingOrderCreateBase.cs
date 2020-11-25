using Blazored.Toast.Services;
using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Shared.Models.Product;
using Lenta.Web.Extensions;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.ManufacturingOrders
{
    public class ManufacturingOrderCreateBase : ComponentBase
    {
        [Inject]
        public IManufacturingOrderService ManufacturingOrderService { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        public bool IsLoading { get; set; }
        protected ManufacturingOrderForCreationDto Order { get; set; } = new ManufacturingOrderForCreationDto();
        protected ProductDto Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;

            string productId = NavigationManager.QueryString("product");
            if (string.IsNullOrEmpty(productId))
            {
                NavigationManager.NavigateTo("/error");
            }
            var productRes = await ProductService.GetProduct(productId);
            Product = productRes.Data;
            Order.ProductId = Product.Id;

            IsLoading = false;
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ManufacturingOrderService.CreateOrder(Order);
            if (result != null)
            {
                ToastService.ShowSuccess($"Gamybos užsakymas '{Product.Name}' yra sėkmingai sukurtas");
                NavigationManager.NavigateTo("/morders");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti gamybos užsakymo");
            }
        }
    }
}

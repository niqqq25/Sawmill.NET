using Blazored.Toast.Services;
using Lenta.Shared.Models.Product;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Products
{
    public class ProductCreateBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        protected ProductForCreationDto Product { get; set; } = new ProductForCreationDto();

        protected async Task HandleFormSubmit()
        {
            var result = await ProductService.CreateProduct(Product);
            if (result != null)
            {
                ToastService.ShowSuccess($"Produktas '{Product.Name}' yra sėkmingai sukurtas");
                NavigationManager.NavigateTo("/products");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti produkto");
            }
        }
    }
}

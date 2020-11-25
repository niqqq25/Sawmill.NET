using AutoMapper;
using Blazored.Toast.Services;
using Lenta.Shared.Models.Product;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Products
{
    public class ProductEditBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected ProductForUpdateDto Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Response<ProductDto> response = await ProductService.GetProduct(Id);
            Product = Mapper.Map<ProductForUpdateDto>(response.Data);
        }

        protected async Task HandleFormSubmit()
        {
            var result = await ProductService.EditProduct(Id, Product);
            if (result != null)
            {
                ToastService.ShowSuccess($"Produktas '{Product.Name}' yra sėkmnigai atnaujintas");
                NavigationManager.NavigateTo("/products");
            }
            else
            {
                ToastService.ShowError("Nepavyko atnaujinti produkto");
            }
        }
    }
}

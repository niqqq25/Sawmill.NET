using Blazored.Toast.Services;
using Lenta.Shared.Models.Product;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lenta.Shared.Extensions;
using Lenta.Web.Extensions;

namespace Lenta.Web.Pages.Products
{
    public class ProductListBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        public PagedResponse<List<ProductDto>> PagedResponse { get; set; }
        public string SearchQuery { get; set; }
        public bool IsLoading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SearchQuery = NavigationManager.QueryString("query") ?? "";
            await GetProduct();
        }

        protected void HandleSearch()
        {
            string uri = new UriBuilder(NavigationManager.Uri).ClearQuery().AddQuery("query", SearchQuery).ToString();
            NavigationManager.NavigateTo(uri, true);
        }

        protected void HandlePageChange(int page)
        {
            string uri = new UriBuilder(NavigationManager.Uri).UpdateQuery("page", page.ToString()).ToString();
            NavigationManager.NavigateTo(uri, true);
        }

        protected async Task HandleProductDelete(int id, string name)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Ar tikrai norite ištrinti šį produktą '{name}'?"))
                return;
            var result = await ProductService.DeleteProduct(id.ToString());
            if (result.IsSuccessStatusCode)
            {
                ToastService.ShowSuccess($"Produktas '{name}' buvo sėkmingai ištrintas");
                await GetProduct();
            }
            else
            {
                ToastService.ShowError("Nepavyko ištrinti produkto");
            }
        }

        private async Task GetProduct()
        {
            IsLoading = true;

            Uri uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            PagedResponse = await ProductService.GetProducts(uri.Query);

            IsLoading = false;
        }
    }
}

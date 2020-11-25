using Lenta.Shared.Models.Resource;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lenta.Shared.Extensions;
using Microsoft.JSInterop;
using Blazored.Toast.Services;
using Lenta.Web.Extensions;

namespace Lenta.Web.Pages
{
    public class ResourceListBase : ComponentBase
    {
        [Inject]
        public IResourceService ResourceService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        public PagedResponse<List<ResourceDto>> PagedResponse { get; set; }
        public string SearchQuery { get; set; } = "";
        public bool IsLoading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SearchQuery = NavigationManager.QueryString("query") ?? "";
            await GetResources();
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

        protected async Task HandleResourceDelete(int id, string name)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Ar tikrai norite ištrinti šį resursą '{name}'?"))
                return;
            var result = await ResourceService.DeleteResource(id.ToString());
            if (result.IsSuccessStatusCode)
            {
                ToastService.ShowSuccess("Resursas buvo sėkmingai ištrintas");
                await GetResources();
            }
            else
            {
                ToastService.ShowError("Nepavyko ištrinti resurso");
            }
        }

        private async Task GetResources()
        {
            IsLoading = true;

            Uri uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            PagedResponse = await ResourceService.GetResources(uri.Query);

            IsLoading = false;
        }
    }
}

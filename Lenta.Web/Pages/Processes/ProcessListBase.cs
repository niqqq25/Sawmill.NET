using Blazored.Toast.Services;
using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lenta.Shared.Extensions;
using Lenta.Shared.Types;
using Lenta.Web.Extensions;

namespace Lenta.Web.Pages.Processes
{
    public class ProcessListBase : ComponentBase
    {
        [Inject]
        public IProcessService ProcessService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        public PagedResponse<List<ManufacturingProcessDto>> PagedResponse { get; set; }
        public string SearchQuery { get; set; }
        public bool IsLoading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SearchQuery = NavigationManager.QueryString("query") ?? "";
            await GetProcesses();
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

        protected async Task HandleProcessDelete(int id, string name)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Ar tikrai norite ištrinti šį procesą '{name}'?"))
                return;
            var result = await ProcessService.DeleteProcess(id.ToString());
            if (result.IsSuccessStatusCode)
            {
                ToastService.ShowSuccess($"Procesas '{name}' buvo sėkmingai ištrintas");
                await GetProcesses();
            }
            else
            {
                ToastService.ShowError("Nepavyko ištrinti proceso");
            }
        }

        private async Task GetProcesses()
        {
            IsLoading = true;

            Uri uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            PagedResponse = await ProcessService.GetProcesses(uri.Query);

            IsLoading = false;
        }

        protected string GetStatusColor(ManufacturingProcessStatus status)
        {
            return status switch
            {
                ManufacturingProcessStatus.Neaktyvus => "#6C757D",
                ManufacturingProcessStatus.Mažas => "#28A745",
                ManufacturingProcessStatus.Vidutinis => "#FFC107",
                ManufacturingProcessStatus.Didelis => "#DC3545",
                _ => "#666666",
            };
        }
    }
}

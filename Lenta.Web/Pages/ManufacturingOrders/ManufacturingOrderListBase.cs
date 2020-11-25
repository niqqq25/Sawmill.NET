using Lenta.Shared.Models.ManufacturingOrder;
using Lenta.Shared.Wrappers;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lenta.Shared.Extensions;
using Lenta.Shared.Types;
using Lenta.Web.Extensions;

namespace Lenta.Web.Pages.ManufacturingOrders
{
    public class ManufacturingOrderListBase : ComponentBase
    {
        [Inject]
        public IManufacturingOrderService ManufacturingOrderService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public PagedResponse<List<ManufacturingOrderDto>> PagedResponse { get; set; }
        public string SearchQuery { get; set; }
        public int SearchStatus { get; set; }
        public bool IsDateAsc { get; set; }
        public bool IsLoading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SearchQuery = NavigationManager.QueryString("query") ?? "";

            string statusQueryString = NavigationManager.QueryString("status");
            SearchStatus = string.IsNullOrEmpty(statusQueryString) ? -1 : int.Parse(statusQueryString);

            bool.TryParse(NavigationManager.QueryString("dateAsc"), out bool isDateAsc);
            IsDateAsc = isDateAsc;

            await GetOrders();
        }

        protected void HandleSearch()
        {
            UriBuilder uriBuilder = new UriBuilder(NavigationManager.Uri).ClearQuery();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                uriBuilder.AddQuery("query", SearchQuery);
            }

            if (SearchStatus != -1)
            {
                uriBuilder.AddQuery("status", SearchStatus.ToString());
            }

            if (IsDateAsc)
            {
                uriBuilder.AddQuery("dateAsc", IsDateAsc.ToString());
            }

            NavigationManager.NavigateTo(uriBuilder.ToString(), true);
        }

        protected void HandlePageChange(int page)
        {
            string uri = new UriBuilder(NavigationManager.Uri).UpdateQuery("page", page.ToString()).ToString();
            NavigationManager.NavigateTo(uri, true);
        }

        private async Task GetOrders()
        {
            IsLoading = true;

            Uri uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            PagedResponse = await ManufacturingOrderService.GetOrders(uri.Query);

            IsLoading = false;
        }

        protected string GetStatusColor(ManufacturingOrderStatus status)
        {
            return status switch
            {
                ManufacturingOrderStatus.Vykdomas => "#28A745",
                ManufacturingOrderStatus.Atšauktas => "#343A40",
                ManufacturingOrderStatus.Pabaigtas => "#6C757D",
                _ => "#6C757D",
            };
        }
    }
}

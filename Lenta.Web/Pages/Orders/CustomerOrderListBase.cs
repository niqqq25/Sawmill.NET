using Lenta.Shared.Models.CustomerOrder;
using Lenta.Shared.Wrappers;
using Lenta.Web.Extensions;
using Lenta.Shared.Extensions;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lenta.Shared.Types;

namespace Lenta.Web.Pages.Orders
{
    public class CustomerOrderListBase : ComponentBase
    {
        [Inject]
        public ICustomerOrderService CustomerOrderService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public PagedResponse<List<CustomerOrderDto>> PagedResponse { get; set; }
        public int SearchStatus { get; set; }
        public bool IsDateAsc { get; set; }
        public bool IsLoading { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string statusQueryString = NavigationManager.QueryString("status");
            SearchStatus = string.IsNullOrEmpty(statusQueryString) ? -1 : int.Parse(statusQueryString);

            bool.TryParse(NavigationManager.QueryString("dateAsc"), out bool isDateAsc);
            IsDateAsc = isDateAsc;

            await GetOrders();
        }

        protected void HandleSearch()
        {
            UriBuilder uriBuilder = new UriBuilder(NavigationManager.Uri).ClearQuery();

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
            PagedResponse = await CustomerOrderService.GetOrders(uri.Query);

            IsLoading = false;
        }

        protected string GetStatusColor(CustomerOrderStatus status)
        {
            switch (status)
            {
                case CustomerOrderStatus.Ruošiama:
                case CustomerOrderStatus.Gaminama:
                    return "#6FA8DC";
                case CustomerOrderStatus.Paruošta:
                    return "#28A745";
                case CustomerOrderStatus.Atšaukta:
                    return "#999999";
                case CustomerOrderStatus.Užbaigta:
                    return "#6C757D";
                default:
                    return "#6C757D";
            }
        }
    }
}

using Blazored.Toast.Services;
using Lenta.Shared.Models.Customer;
using Lenta.Shared.Models.CustomerOrder;
using Lenta.Shared.Models.CustomerOrderItem;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Orders
{
    public class CustomerOrderCreateBase : ComponentBase
    {
        [Inject]
        public ICustomerOrderService CustomerOrderService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        protected CustomerOrderForCreationDto Order { get; set; }
        protected CustomerOrderItemForCreationDto OrderItem { get; set; } = new CustomerOrderItemForCreationDto();

        protected override void OnInitialized()
        {
            Order = new CustomerOrderForCreationDto()
            {
                Customer = new CustomerForCreationDto(),
                OrderItems = new List<CustomerOrderItemForCreationDto>()
            };
        }

        protected async Task HandleFormSubmit()
        {
            var result = await CustomerOrderService.CreateOrder(Order);
            if (result != null)
            {
                ToastService.ShowSuccess($"Užsakymas '{result.Id}' yra sėkmingai sukurtas");
                NavigationManager.NavigateTo("/orders");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti užsakymo");
            }
        }

        protected void AddProduct()
        {
            Order.OrderItems.Add(OrderItem);
            OrderItem = new CustomerOrderItemForCreationDto();
        }

        protected void RemoveProduct(int productIndex)
        {
            Order.OrderItems.RemoveAt(productIndex);
        }
    }
}

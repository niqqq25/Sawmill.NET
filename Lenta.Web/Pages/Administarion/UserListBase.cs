using Blazored.Toast.Services;
using Lenta.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Administarion
{
    public class UserListBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        protected UserManager<ApplicationUser> UserManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        public List<UserModel> Users { get; set; }

        public class UserModel
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            await GetUsers();
        }

        protected async Task GetUsers()
        {
            var users = UserManager.Users.ToList();
            Users = new List<UserModel>();
            foreach (var user in users)
            {
                var roles = await UserManager.GetRolesAsync(user);
                UserModel userModel = new UserModel()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = roles[0]
                };
                Users.Add(userModel);
            }
        }

        protected async Task HandleUserDelete(string id, string name)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Ar tikrai norite ištrinti šią paskyrą '{name}'?"))
                return;
            var user = await UserManager.FindByIdAsync(id);
            var result = await UserManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                await GetUsers();
                ToastService.ShowSuccess("Darbuotojo paskyra buvo sėkmingai ištrinta");
            }
            else
            {
                ToastService.ShowError("Nepavyko ištrinti darbuotojo paskyros");
            }
        }
    }
}

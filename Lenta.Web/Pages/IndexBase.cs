using Lenta.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Lenta.Web.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        public UserManager<ApplicationUser> UserManager { get; set; }
        public string Name { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = await UserManager.GetUserAsync(state.User);
            Name = $"{user.FirstName} {user.LastName}";
        }
    }
}

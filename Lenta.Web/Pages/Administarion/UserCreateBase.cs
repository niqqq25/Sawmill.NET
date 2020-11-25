using Blazored.Toast.Services;
using Lenta.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lenta.Web.Pages.Administarion
{
    public class UserCreateBase : ComponentBase
    {
        [Inject]
        protected UserManager<ApplicationUser> UserManager { get; set; }
        [Inject]
        protected RoleManager<IdentityRole> RoleManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public List<IdentityRole> Roles { get; set; }

        public class UserModel
        {
            [Required(ErrorMessage = "Prašome įvesti darbuotojo vardą")]
            [MaxLength(50, ErrorMessage = "Vardas turi neviršyti 50 simbolių")]
            public string FirstName { get; set; }
            [Required(ErrorMessage = "Prašome įvesti darbuotojo pavardę")]
            [MaxLength(50, ErrorMessage = "Pavardė turi neviršyti 50 simbolių")]
            public string LastName { get; set; }
            [Required(ErrorMessage = "Prašome įvesti elektroninį paštą")]
            [EmailAddress(ErrorMessage = "Prašome įvesti teisingą elektroninį paštą")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Prašome įvesti slaptažodį")]
            [MinLength(4, ErrorMessage = "Slaptažodis turi turėti bent 4 simbolius")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Compare("Password", ErrorMessage = "Slaptažodžiai nesutampa")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
            [Required(ErrorMessage = "Prašome pasirinkti pareigas")]
            public string Role { get; set; }
        }

        protected override void OnInitialized()
        {
            Roles = RoleManager.Roles.ToList();
        }

        protected async Task HandleUserCreate()
        {
            if (!await RoleManager.RoleExistsAsync(User.Role))
            {
                ToastService.ShowError("Tokios pareigos neegzistuoja");
                return;
            }

            var user = new ApplicationUser { UserName = User.Email, Email = User.Email, FirstName = User.FirstName, LastName = User.LastName };
            var userCreateResult = await UserManager.CreateAsync(user, User.Password);
            if (userCreateResult.Succeeded)
            {
                await UserManager.AddToRoleAsync(user, User.Role);
                ToastService.ShowSuccess($"Darbuotojo paskyra yra sėkmingai sukurta");
                NavigationManager.NavigateTo("/users");
            }
            else
            {
                ToastService.ShowError("Nepavyko sukurti darbuotojo paskyros");
            }
        }
    }
}

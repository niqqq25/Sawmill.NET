using System;
using Lenta.Web.Areas.Identity.Data;
using Lenta.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lenta.Web.Areas.Identity.IdentityHostingStartup))]
namespace Lenta.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LentaWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LentaWebContextConnection")));

                services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                        options.Password.RequireDigit = false;
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequiredLength = 4;
                }).AddEntityFrameworkStores<LentaWebContext>();
            });
        }
    }
}
using System;
using AutoMapper;
using Blazored.Toast;
using Lenta.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lenta.Web
{
    public class Startup
    {
        private const string UriString = "http://localhost:54010/";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddAuthentication("Identity.Application").AddCookie();
            services.AddRazorPages().AddNewtonsoftJson();
            services.AddServerSideBlazor();
            services.AddBlazoredToast();

            services.AddHttpClient<IResourceService, ResourceService>(config => config.BaseAddress = new Uri(UriString));
            services.AddHttpClient<IProductService, ProductService>(config => config.BaseAddress = new Uri(UriString));
            services.AddHttpClient<IProcessService, ProcessService>(config => config.BaseAddress = new Uri(UriString));
            services.AddHttpClient<IManufacturingOrderService, ManufacturingOrderService>(config => config.BaseAddress = new Uri(UriString));
            services.AddHttpClient<ICustomerOrderService, CustomerOrderService>(config => config.BaseAddress = new Uri(UriString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

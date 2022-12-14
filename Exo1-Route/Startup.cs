using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

              // domaine/Contrat-de-confidentialite
                endpoints.MapControllerRoute(
                    name: "Privacy",
                    pattern: "Contrat-de-confidentialite",
                    defaults: new { Action = "Privacy" , Controller = "Home" });

                // domaine/Index 
                // domaine/Home
                endpoints.MapControllerRoute(
                    name: "Index",
                    pattern: "{action=Index}",
                    defaults: new { Controller = "Home" });

                // domaine/Monsite
                // domaine/Monsite/Index
                // domaine/Monsite/Privacy
                endpoints.MapControllerRoute(
                    name: "Monsite",
                    pattern: "Monsite/{action=Index}",
                    defaults: new { Controller = "Home" });

                // domaine
                // domaine/Home
                // domaine/Home/Index
                // domaine/Home/Privacy
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

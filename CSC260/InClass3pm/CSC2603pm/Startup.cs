using CSC2603pm.Data;
using CSC2603pm.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC2603pm
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
            services.AddDbContext<MovieContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("MovieDB"));
            });

            services.AddTransient<IDataAccessLayer, MovieListDAL>();

            services.AddRazorPages();
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
                endpoints.MapControllerRoute(
                    name: "PizzaToTest",
                    pattern: "pizza",
                //    //pattern: "pizza{id}",
                //    //pattern: "pizza/{id?}",
                //    pattern: "pizza/{moo:int}/PageNum{bah}",
                    defaults: new { controller = "Home", action = "MooStuff" });

                              

                endpoints.MapControllerRoute(
                    name: "many",
                    pattern: "colors/{*colors}",
                    defaults: new { controller = "Home", action = "Colors" }
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });

            //endpoints.MapControllerRoute(
            //    name: "catchall",
            //    pattern: "{*catchall}",  //could be anything instead of catchall
            //    defaults: new { controller = "home", action = "error" }  //looks for home/error, if not there then shared/error
            //   );


        }
    }
}

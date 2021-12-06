using CandyStore.Data;
using CandyStore.Models;
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

namespace CandyStore
{
    public class Startup
    {
        //Allows access to Connection String via IConfiguration interface
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }





        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllersWithViews(); //Added@2.3
            services.AddScoped<ICandyRepository, CandyRepository>(); //Added@3.5
            services.AddScoped<ICategoryRepository, CategoryRepository>(); //Added@3.5
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); //Added@5.2

            //Added@6.8 {
            services.AddScoped<ShoppingCart>(shoppingCartObject => ShoppingCart.GetCart(shoppingCartObject)); 
            services.AddHttpContextAccessor();
            services.AddSession();
            // }
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
            app.UseSession();//Added@6.8
            app.UseRouting();
            app.UseAuthorization();




            
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();

                //added@3.2
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });          

        }
    }
}

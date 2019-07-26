using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Mocks;
using DrinkAndGo.Data.Models;
using DrinkAndGo.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DrinkAndGo
{
    public class Startup
    {
	    private IConfigurationRoot _configurationRoot;

	    public Startup(IHostingEnvironment hostingEnvironment)
	    {
		    _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
			    .AddJsonFile("appsettings.json")
			    .Build();
	    }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			//Server configuration

	        services.AddDbContext<AppDbContext>(options =>
		        options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

			services.AddIdentity<IdentityUser, IdentityRole>()
				.AddEntityFrameworkStores<AppDbContext>();
	        services.AddTransient<IDrinkRepository, DrinkRepository>();
	        services.AddTransient<ICategoryRepository, CategoryRepository>();
	        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
	        services.AddScoped(sp => ShoppingCart.GetCart(sp));
			services.AddTransient<IOrderRepository, OrderRepository>();

			services.AddMvc();
	        services.AddMemoryCache();
	        services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
	        loggerFactory.AddConsole();
	        app.UseDeveloperExceptionPage();
	        app.UseStaticFiles();
	        app.UseStatusCodePages();
	        app.UseSession();
	        app.UseMvc(routes =>
	        {
		        routes.MapRoute(name: "categoryFilter", template: "Drink/{action}/{category?}",
			        defaults: new {Controller = "Drink", action = "DrinkList"});
			        routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
		        });
	        DbInitializer.Seed(serviceProvider);


		}
	}
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Contexts;
using MusicStore.Repositories;
using MusicStore.Repositories.Interfaces;
using System;

namespace MusicStore
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Config = config;
        }

        public IConfiguration Config { get; }

        public void ConfigureServices(IServiceCollection svc)
        {
            Console.WriteLine("debug: Adding services to container..");

            // Database contexts
            svc.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(Config["Data:MusicStoreCustomers:ConnectionString"]));

            // Repositories
            svc.AddTransient<ICustomerRepository, CustomerRepositoryEF>();

            // Frameworks
            svc.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Console.WriteLine("debug: Configuring HTTP request pipeline..");

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Customer}/{action=List}/{id?}");
            });

            Migrations.SeedData.Customers.EnsurePopulated(app);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Repositories;
using MusicStore.Repositories.Interfaces;

namespace MusicStore
{
    public class Startup
    {
        // Add services to container
        public void ConfigureServices(IServiceCollection services)
        {
            // Repositories
            services.AddTransient<ICustomerRepository, FakeCustomerRepository>();

            // Frameworks
            services.AddMvc();
        }

        // Configure HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                // TODO: Set default routing
            });
        }
    }
}

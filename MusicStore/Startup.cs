using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Models.Repositories;

namespace MusicStore
{
    public class Startup
    {
        // Add services to container
        public void ConfigureServices(IServiceCollection services)
        {
            // Repositories
            services.AddTransient<IAlbumRepository, FakeAlbumRepository>();
            services.AddTransient<IArtistRepository, FakeArtistRepository>();
            services.AddTransient<IGenreRepository, FakeGenreRepository>();
            services.AddTransient<ILabelRepository, FakeLabelRepository>();
            services.AddTransient<ITrackRepository, FakeTrackRepository>();
            services.AddTransient<IVersionRepository, FakeVersionRepository>();

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

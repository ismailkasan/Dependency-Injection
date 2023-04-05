

using DependencyInjection.Repository;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddMvc(option =>
            {
                option.EnableEndpointRouting = false;
            });
        }
        public void Configure(IApplicationBuilder app)
        {

            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseMvc();
        }
    }
}

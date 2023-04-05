using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DependencyInjection
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            .ConfigureKestrel(options =>
            {
                options.Limits.MaxRequestBodySize = long.MaxValue; //50MB
                options.Limits.MaxResponseBufferSize = long.MaxValue; //50MB
                options.Limits.MaxRequestBufferSize = long.MaxValue; //50MB
            });
    }
}

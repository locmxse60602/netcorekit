using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace NetCoreKit.Samples.TodoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging(builder => builder.AddConsole().AddDebug())
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(o => o.ValidateScopes = false /* because of MySQL */);
        }
    }
}

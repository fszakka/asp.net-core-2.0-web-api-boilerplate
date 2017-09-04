using System;
using System.IO;
using CoreApi.DataContext.Core;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace CoreApi.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = BuildWebHost(args);

                InitializeDatabase(host);
                host.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseUrls("http://0.0.0.0:5001")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseSerilog()
                .Build();

        private static void InitializeDatabase(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<CoreContext>();
                    DatabaseInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
        }
    }
}

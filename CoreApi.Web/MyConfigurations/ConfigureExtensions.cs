using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

namespace CoreApi.Web.MyConfigurations
{
    public static class ConfigureExtensions
    {
        public static void ConfigureSerilog(this IApplicationBuilder app, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.RollingFile(@"logs\log-{Date}.txt")
                .CreateLogger();
        }
    }
}

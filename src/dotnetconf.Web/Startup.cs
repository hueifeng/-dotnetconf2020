using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace dotnetconf.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<dotnetconfWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace dotnetconf
{
    public class dotnetconfWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<dotnetconfWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace dotnetconf.EntityFrameworkCore
{
    [DependsOn(
        typeof(dotnetconfEntityFrameworkCoreModule)
        )]
    public class dotnetconfEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<dotnetconfMigrationsDbContext>();
        }
    }
}

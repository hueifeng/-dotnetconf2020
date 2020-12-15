using dotnetconf.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace dotnetconf.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(dotnetconfEntityFrameworkCoreDbMigrationsModule),
        typeof(dotnetconfApplicationContractsModule)
        )]
    public class dotnetconfDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

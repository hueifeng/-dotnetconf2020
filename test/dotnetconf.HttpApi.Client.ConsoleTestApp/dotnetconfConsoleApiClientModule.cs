using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace dotnetconf.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(dotnetconfHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class dotnetconfConsoleApiClientModule : AbpModule
    {
        
    }
}

using Volo.Abp.Modularity;

namespace dotnetconf
{
    [DependsOn(
        typeof(dotnetconfApplicationModule),
        typeof(dotnetconfDomainTestModule)
        )]
    public class dotnetconfApplicationTestModule : AbpModule
    {

    }
}
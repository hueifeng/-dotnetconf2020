using dotnetconf.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace dotnetconf
{
    [DependsOn(
        typeof(dotnetconfEntityFrameworkCoreTestModule)
        )]
    public class dotnetconfDomainTestModule : AbpModule
    {

    }
}
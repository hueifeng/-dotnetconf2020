using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace dotnetconf.Web
{
    [Dependency(ReplaceServices = true)]
    public class dotnetconfBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "dotnetconf";
    }
}

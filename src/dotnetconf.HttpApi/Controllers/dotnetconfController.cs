using dotnetconf.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace dotnetconf.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class dotnetconfController : AbpController
    {
        protected dotnetconfController()
        {
            LocalizationResource = typeof(dotnetconfResource);
        }
    }
}
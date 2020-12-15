using dotnetconf.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace dotnetconf.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class dotnetconfPageModel : AbpPageModel
    {
        protected dotnetconfPageModel()
        {
            LocalizationResourceType = typeof(dotnetconfResource);
        }
    }
}
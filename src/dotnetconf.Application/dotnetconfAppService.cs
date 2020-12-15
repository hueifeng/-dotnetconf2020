using System;
using System.Collections.Generic;
using System.Text;
using dotnetconf.Localization;
using Volo.Abp.Application.Services;

namespace dotnetconf
{
    /* Inherit your application services from this class.
     */
    public abstract class dotnetconfAppService : ApplicationService
    {
        protected dotnetconfAppService()
        {
            LocalizationResource = typeof(dotnetconfResource);
        }
    }
}

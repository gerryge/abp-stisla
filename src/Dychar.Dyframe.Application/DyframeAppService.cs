using System;
using System.Collections.Generic;
using System.Text;
using Dychar.Dyframe.Localization;
using Volo.Abp.Application.Services;

namespace Dychar.Dyframe
{
    /* Inherit your application services from this class.
     */
    public abstract class DyframeAppService : ApplicationService
    {
        protected DyframeAppService()
        {
            LocalizationResource = typeof(DyframeResource);
        }
    }
}

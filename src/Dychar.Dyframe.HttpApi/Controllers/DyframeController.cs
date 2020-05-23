using Dychar.Dyframe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dychar.Dyframe.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DyframeController : AbpController
    {
        protected DyframeController()
        {
            LocalizationResource = typeof(DyframeResource);
        }
    }
}
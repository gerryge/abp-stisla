using Dychar.Dyframe.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dychar.Dyframe.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DyframePageModel : AbpPageModel
    {
        protected DyframePageModel()
        {
            LocalizationResourceType = typeof(DyframeResource);
        }
    }
}
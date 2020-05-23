using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Dychar.Abp.AspNetCore.Mvc.Ui.Theme.Stisla.Themes.Stisla.Components.LeftNavbar
{
    public class LeftNavbarViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Stisla/Components/LeftNavbar/Default.cshtml");
        }
    }
}

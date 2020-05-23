using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Dychar.Abp.AspNetCore.Mvc.Ui.Theme.Stisla.Themes.Stisla.Components.TopNavbar
{
    public class TopNavbarViewComponent : AbpViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Stisla/Components/TopNavbar/Default.cshtml");
        }
    }
}

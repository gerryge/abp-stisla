using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Dychar.Dyframe.Localization;
using Dychar.Dyframe.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Dychar.Dyframe.Web.Menus
{
    public class DyframeMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<DyframeResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Dyframe.Home", l["Menu:Home"], "/"));
        }
    }
}

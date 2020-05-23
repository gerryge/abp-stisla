using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Dychar.Dyframe.Web
{
    [Dependency(ReplaceServices = true)]
    public class DyframeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Dyframe";
    }
}

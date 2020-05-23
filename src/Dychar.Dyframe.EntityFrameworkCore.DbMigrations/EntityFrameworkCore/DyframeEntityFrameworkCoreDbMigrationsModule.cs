using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Dychar.Dyframe.EntityFrameworkCore
{
    [DependsOn(
        typeof(DyframeEntityFrameworkCoreModule)
        )]
    public class DyframeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DyframeMigrationsDbContext>();
        }
    }
}

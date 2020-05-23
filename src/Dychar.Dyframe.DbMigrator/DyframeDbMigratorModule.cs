using Dychar.Dyframe.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dychar.Dyframe.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DyframeEntityFrameworkCoreDbMigrationsModule),
        typeof(DyframeApplicationContractsModule)
        )]
    public class DyframeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

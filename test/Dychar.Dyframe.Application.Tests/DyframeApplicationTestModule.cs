using Volo.Abp.Modularity;

namespace Dychar.Dyframe
{
    [DependsOn(
        typeof(DyframeApplicationModule),
        typeof(DyframeDomainTestModule)
        )]
    public class DyframeApplicationTestModule : AbpModule
    {

    }
}
using Dychar.Dyframe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dychar.Dyframe
{
    [DependsOn(
        typeof(DyframeEntityFrameworkCoreTestModule)
        )]
    public class DyframeDomainTestModule : AbpModule
    {

    }
}
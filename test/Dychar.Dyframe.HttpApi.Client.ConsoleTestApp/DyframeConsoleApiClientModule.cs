using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Dychar.Dyframe.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DyframeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DyframeConsoleApiClientModule : AbpModule
    {
        
    }
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dychar.Dyframe.Data
{
    /* This is used if database provider does't define
     * IDyframeDbSchemaMigrator implementation.
     */
    public class NullDyframeDbSchemaMigrator : IDyframeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
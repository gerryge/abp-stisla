using System.Threading.Tasks;

namespace Dychar.Dyframe.Data
{
    public interface IDyframeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

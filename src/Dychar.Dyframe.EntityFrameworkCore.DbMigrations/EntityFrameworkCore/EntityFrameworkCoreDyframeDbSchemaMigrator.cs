using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dychar.Dyframe.Data;
using Volo.Abp.DependencyInjection;

namespace Dychar.Dyframe.EntityFrameworkCore
{
    public class EntityFrameworkCoreDyframeDbSchemaMigrator
        : IDyframeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDyframeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DyframeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DyframeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
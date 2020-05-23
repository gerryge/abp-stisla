using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dychar.Dyframe.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DyframeMigrationsDbContextFactory : IDesignTimeDbContextFactory<DyframeMigrationsDbContext>
    {
        public DyframeMigrationsDbContext CreateDbContext(string[] args)
        {
            DyframeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DyframeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DyframeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

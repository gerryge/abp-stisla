using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Dychar.Dyframe.EntityFrameworkCore
{
    public static class DyframeDbContextModelCreatingExtensions
    {
        public static void ConfigureDyframe(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DyframeConsts.DbTablePrefix + "YourEntities", DyframeConsts.DbSchema);

            //    //...
            //});
        }
    }
}
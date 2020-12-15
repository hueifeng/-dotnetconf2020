using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace dotnetconf.EntityFrameworkCore
{
    public static class dotnetconfDbContextModelCreatingExtensions
    {
        public static void Configuredotnetconf(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(dotnetconfConsts.DbTablePrefix + "YourEntities", dotnetconfConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
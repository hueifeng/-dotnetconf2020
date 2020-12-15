using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace dotnetconf.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class dotnetconfMigrationsDbContextFactory : IDesignTimeDbContextFactory<dotnetconfMigrationsDbContext>
    {
        public dotnetconfMigrationsDbContext CreateDbContext(string[] args)
        {
            dotnetconfEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<dotnetconfMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new dotnetconfMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../dotnetconf.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

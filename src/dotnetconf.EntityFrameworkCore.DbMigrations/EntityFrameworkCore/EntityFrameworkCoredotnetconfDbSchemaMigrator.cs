using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using dotnetconf.Data;
using Volo.Abp.DependencyInjection;

namespace dotnetconf.EntityFrameworkCore
{
    public class EntityFrameworkCoredotnetconfDbSchemaMigrator
        : IdotnetconfDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoredotnetconfDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the dotnetconfMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<dotnetconfMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
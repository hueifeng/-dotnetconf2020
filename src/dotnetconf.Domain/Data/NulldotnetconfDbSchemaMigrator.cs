using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace dotnetconf.Data
{
    /* This is used if database provider does't define
     * IdotnetconfDbSchemaMigrator implementation.
     */
    public class NulldotnetconfDbSchemaMigrator : IdotnetconfDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
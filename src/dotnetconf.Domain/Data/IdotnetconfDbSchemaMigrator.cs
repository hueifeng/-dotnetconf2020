using System.Threading.Tasks;

namespace dotnetconf.Data
{
    public interface IdotnetconfDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

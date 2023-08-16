using System.Threading.Tasks;

namespace Myapp.Data;

public interface IMyappDbSchemaMigrator
{
    Task MigrateAsync();
}

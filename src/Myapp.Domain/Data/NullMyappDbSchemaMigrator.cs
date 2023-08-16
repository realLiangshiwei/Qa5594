using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Myapp.Data;

/* This is used if database provider does't define
 * IMyappDbSchemaMigrator implementation.
 */
public class NullMyappDbSchemaMigrator : IMyappDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Moduleapp.EntityFrameworkCore;

[ConnectionStringName(ModuleappDbProperties.ConnectionStringName)]
public interface IModuleappDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}

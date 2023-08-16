using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Moduleapp.EntityFrameworkCore;

[ConnectionStringName(ModuleappDbProperties.ConnectionStringName)]
public class ModuleappDbContext : AbpDbContext<ModuleappDbContext>, IModuleappDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ModuleappDbContext(DbContextOptions<ModuleappDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureModuleapp();
    }
}

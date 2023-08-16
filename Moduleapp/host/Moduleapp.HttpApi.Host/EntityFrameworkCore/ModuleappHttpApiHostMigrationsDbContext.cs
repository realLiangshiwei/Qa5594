using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Moduleapp.EntityFrameworkCore;

public class ModuleappHttpApiHostMigrationsDbContext : AbpDbContext<ModuleappHttpApiHostMigrationsDbContext>
{
    public ModuleappHttpApiHostMigrationsDbContext(DbContextOptions<ModuleappHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureModuleapp();
    }
}

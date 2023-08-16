using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Moduleapp.EntityFrameworkCore;

public class ModuleappHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleappHttpApiHostMigrationsDbContext>
{
    public ModuleappHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModuleappHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Moduleapp"));

        return new ModuleappHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

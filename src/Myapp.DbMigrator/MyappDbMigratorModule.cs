using Myapp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Myapp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyappEntityFrameworkCoreModule),
    typeof(MyappApplicationContractsModule)
    )]
public class MyappDbMigratorModule : AbpModule
{
}

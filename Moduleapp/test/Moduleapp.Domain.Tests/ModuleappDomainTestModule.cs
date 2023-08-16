using Moduleapp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Moduleapp;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ModuleappEntityFrameworkCoreTestModule)
    )]
public class ModuleappDomainTestModule : AbpModule
{

}

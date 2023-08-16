using Myapp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Myapp;

[DependsOn(
    typeof(MyappEntityFrameworkCoreTestModule)
    )]
public class MyappDomainTestModule : AbpModule
{

}

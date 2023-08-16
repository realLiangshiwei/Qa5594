using Volo.Abp.Modularity;

namespace Myapp;

[DependsOn(
    typeof(MyappApplicationModule),
    typeof(MyappDomainTestModule)
    )]
public class MyappApplicationTestModule : AbpModule
{

}

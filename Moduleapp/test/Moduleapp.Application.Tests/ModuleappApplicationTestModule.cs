using Volo.Abp.Modularity;

namespace Moduleapp;

[DependsOn(
    typeof(ModuleappApplicationModule),
    typeof(ModuleappDomainTestModule)
    )]
public class ModuleappApplicationTestModule : AbpModule
{

}

using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Moduleapp;

[DependsOn(
    typeof(ModuleappDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ModuleappApplicationContractsModule : AbpModule
{

}

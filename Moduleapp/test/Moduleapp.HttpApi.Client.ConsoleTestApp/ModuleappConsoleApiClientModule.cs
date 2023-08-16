using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Moduleapp;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModuleappHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ModuleappConsoleApiClientModule : AbpModule
{

}

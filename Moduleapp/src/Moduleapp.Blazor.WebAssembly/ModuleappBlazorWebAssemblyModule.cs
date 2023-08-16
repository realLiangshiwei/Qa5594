using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Moduleapp.Blazor.WebAssembly;

[DependsOn(
    typeof(ModuleappBlazorModule),
    typeof(ModuleappHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ModuleappBlazorWebAssemblyModule : AbpModule
{

}

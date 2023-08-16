using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Moduleapp.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ModuleappBlazorModule)
    )]
public class ModuleappBlazorServerModule : AbpModule
{

}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Moduleapp;

[DependsOn(
    typeof(ModuleappApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ModuleappHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ModuleappApplicationContractsModule).Assembly,
            ModuleappRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleappHttpApiClientModule>();
        });

    }
}

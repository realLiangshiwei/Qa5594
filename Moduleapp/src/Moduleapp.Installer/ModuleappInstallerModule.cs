using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Moduleapp;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ModuleappInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleappInstallerModule>();
        });
    }
}

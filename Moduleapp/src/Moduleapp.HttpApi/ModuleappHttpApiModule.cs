using Localization.Resources.AbpUi;
using Moduleapp.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Moduleapp;

[DependsOn(
    typeof(ModuleappApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ModuleappHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ModuleappHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ModuleappResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}

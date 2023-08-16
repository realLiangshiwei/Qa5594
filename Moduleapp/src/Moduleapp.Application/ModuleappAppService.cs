using Moduleapp.Localization;
using Volo.Abp.Application.Services;

namespace Moduleapp;

public abstract class ModuleappAppService : ApplicationService
{
    protected ModuleappAppService()
    {
        LocalizationResource = typeof(ModuleappResource);
        ObjectMapperContext = typeof(ModuleappApplicationModule);
    }
}

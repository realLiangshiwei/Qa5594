using Moduleapp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Moduleapp;

public abstract class ModuleappController : AbpControllerBase
{
    protected ModuleappController()
    {
        LocalizationResource = typeof(ModuleappResource);
    }
}

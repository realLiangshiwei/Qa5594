using Moduleapp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Moduleapp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModuleappPageModel : AbpPageModel
{
    protected ModuleappPageModel()
    {
        LocalizationResourceType = typeof(ModuleappResource);
        ObjectMapperContext = typeof(ModuleappWebModule);
    }
}

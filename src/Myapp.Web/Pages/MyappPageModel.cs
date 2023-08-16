using Myapp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Myapp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MyappPageModel : AbpPageModel
{
    protected MyappPageModel()
    {
        LocalizationResourceType = typeof(MyappResource);
    }
}

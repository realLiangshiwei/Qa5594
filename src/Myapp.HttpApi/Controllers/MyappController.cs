using Myapp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Myapp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyappController : AbpControllerBase
{
    protected MyappController()
    {
        LocalizationResource = typeof(MyappResource);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Myapp.Localization;
using Volo.Abp.Application.Services;

namespace Myapp;

/* Inherit your application services from this class.
 */
public abstract class MyappAppService : ApplicationService
{
    protected MyappAppService()
    {
        LocalizationResource = typeof(MyappResource);
    }
}

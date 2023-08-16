using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Myapp.Web;

[Dependency(ReplaceServices = true)]
public class MyappBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Myapp";
}

using Moduleapp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Moduleapp.Permissions;

public class ModuleappPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModuleappPermissions.GroupName, L("Permission:Moduleapp"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModuleappResource>(name);
    }
}

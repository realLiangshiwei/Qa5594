using Volo.Abp.Reflection;

namespace Moduleapp.Permissions;

public class ModuleappPermissions
{
    public const string GroupName = "Moduleapp";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModuleappPermissions));
    }
}

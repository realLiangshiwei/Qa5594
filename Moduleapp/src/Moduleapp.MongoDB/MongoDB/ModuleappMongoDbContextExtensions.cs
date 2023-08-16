using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Moduleapp.MongoDB;

public static class ModuleappMongoDbContextExtensions
{
    public static void ConfigureModuleapp(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}

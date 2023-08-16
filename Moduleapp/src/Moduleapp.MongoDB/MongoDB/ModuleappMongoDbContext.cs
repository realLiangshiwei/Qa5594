using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Moduleapp.MongoDB;

[ConnectionStringName(ModuleappDbProperties.ConnectionStringName)]
public class ModuleappMongoDbContext : AbpMongoDbContext, IModuleappMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureModuleapp();
    }
}

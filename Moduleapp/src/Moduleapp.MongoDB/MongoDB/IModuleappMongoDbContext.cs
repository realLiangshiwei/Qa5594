using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Moduleapp.MongoDB;

[ConnectionStringName(ModuleappDbProperties.ConnectionStringName)]
public interface IModuleappMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}

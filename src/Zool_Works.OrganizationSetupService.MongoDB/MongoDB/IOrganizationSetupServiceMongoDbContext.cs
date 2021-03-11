using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Zool_Works.OrganizationSetupService.MongoDB
{
    [ConnectionStringName(OrganizationSetupServiceDbProperties.ConnectionStringName)]
    public interface IOrganizationSetupServiceMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}

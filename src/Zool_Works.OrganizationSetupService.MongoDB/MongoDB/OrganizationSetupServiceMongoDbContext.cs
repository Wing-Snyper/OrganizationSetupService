using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Zool_Works.OrganizationSetupService.MongoDB
{
    [ConnectionStringName(OrganizationSetupServiceDbProperties.ConnectionStringName)]
    public class OrganizationSetupServiceMongoDbContext : AbpMongoDbContext, IOrganizationSetupServiceMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureOrganizationSetupService();
        }
    }
}
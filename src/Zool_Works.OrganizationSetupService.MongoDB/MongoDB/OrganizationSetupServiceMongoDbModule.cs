using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Zool_Works.OrganizationSetupService.MongoDB
{
    [DependsOn(
        typeof(OrganizationSetupServiceDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class OrganizationSetupServiceMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<OrganizationSetupServiceMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}

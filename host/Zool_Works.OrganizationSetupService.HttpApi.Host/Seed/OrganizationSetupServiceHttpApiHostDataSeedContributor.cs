using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Zool_Works.OrganizationSetupService.Seed
{
    public class OrganizationSetupServiceHttpApiHostDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly OrganizationSetupServiceSampleDataSeeder _organizationSetupServiceSampleDataSeeder;
        private readonly ICurrentTenant _currentTenant;

        public OrganizationSetupServiceHttpApiHostDataSeedContributor(
            OrganizationSetupServiceSampleDataSeeder organizationSetupServiceSampleDataSeeder,
            ICurrentTenant currentTenant)
        {
            _organizationSetupServiceSampleDataSeeder = organizationSetupServiceSampleDataSeeder;
            _currentTenant = currentTenant;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            using (_currentTenant.Change(context?.TenantId))
            {
                await _organizationSetupServiceSampleDataSeeder.SeedAsync(context);
            }
        }
    }
}

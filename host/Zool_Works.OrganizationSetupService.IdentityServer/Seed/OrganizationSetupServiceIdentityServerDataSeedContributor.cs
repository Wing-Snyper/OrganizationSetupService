using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Zool_Works.OrganizationSetupService.Seed
{
    public class OrganizationSetupServiceIdentityServerDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly OrganizationSetupServiceSampleIdentityDataSeeder _organizationSetupServiceSampleIdentityDataSeeder;
        private readonly OrganizationSetupServiceIdentityServerDataSeeder _organizationSetupServiceIdentityServerDataSeeder;
        private readonly ICurrentTenant _currentTenant;

        public OrganizationSetupServiceIdentityServerDataSeedContributor(
            OrganizationSetupServiceIdentityServerDataSeeder organizationSetupServiceIdentityServerDataSeeder,
            OrganizationSetupServiceSampleIdentityDataSeeder organizationSetupServiceSampleIdentityDataSeeder,
            ICurrentTenant currentTenant)
        {
            _organizationSetupServiceIdentityServerDataSeeder = organizationSetupServiceIdentityServerDataSeeder;
            _organizationSetupServiceSampleIdentityDataSeeder = organizationSetupServiceSampleIdentityDataSeeder;
            _currentTenant = currentTenant;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            using (_currentTenant.Change(context?.TenantId))
            {
                await _organizationSetupServiceSampleIdentityDataSeeder.SeedAsync(context);
                await _organizationSetupServiceIdentityServerDataSeeder.SeedAsync(context);
            }
        }
    }
}

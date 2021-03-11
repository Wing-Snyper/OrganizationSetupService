using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace Zool_Works.OrganizationSetupService.Seed
{
    public class OrganizationSetupServiceUnifiedDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly OrganizationSetupServiceSampleIdentityDataSeeder _sampleIdentityDataSeeder;
        private readonly OrganizationSetupServiceSampleDataSeeder _organizationSetupServiceSampleDataSeeder;
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        private readonly ICurrentTenant _currentTenant;

        public OrganizationSetupServiceUnifiedDataSeedContributor(
            OrganizationSetupServiceSampleIdentityDataSeeder sampleIdentityDataSeeder,
            IUnitOfWorkManager unitOfWorkManager,
            OrganizationSetupServiceSampleDataSeeder organizationSetupServiceSampleDataSeeder,
            ICurrentTenant currentTenant)
        {
            _sampleIdentityDataSeeder = sampleIdentityDataSeeder;
            _unitOfWorkManager = unitOfWorkManager;
            _organizationSetupServiceSampleDataSeeder = organizationSetupServiceSampleDataSeeder;
            _currentTenant = currentTenant;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await _unitOfWorkManager.Current.SaveChangesAsync();

            using (_currentTenant.Change(context?.TenantId))
            {
                await _sampleIdentityDataSeeder.SeedAsync(context);
                await _unitOfWorkManager.Current.SaveChangesAsync();
                await _organizationSetupServiceSampleDataSeeder.SeedAsync(context);
            }
        }
    }
}

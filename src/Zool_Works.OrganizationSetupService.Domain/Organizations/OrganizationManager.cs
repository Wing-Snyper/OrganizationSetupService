using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class OrganizationManager : DomainService
    {
        private readonly IOrganizationRepository _organizationRepository;
        
        public OrganizationManager(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<Organization> CreateAsync(
            [NotNull] string name,
            [CanBeNull] string about = null,
            [CanBeNull] string webSite = null,
            [CanBeNull] string dateFormat = null,
            [CanBeNull] string taxID = null,
            [CanBeNull] string companyID = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingOrganization = await _organizationRepository.FindByNameAsync(name);
            if (existingOrganization != null)
            {
                throw new OrganizationAlreadyExistsException(name);
            }

            return new Organization(
                GuidGenerator.Create(),
                name,                
                about,
                webSite,
                dateFormat,
                taxID,
                companyID
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Organization organization,
            [NotNull] string newName)
        {
            Check.NotNull(organization, nameof(organization));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingOrganization = await _organizationRepository.FindByNameAsync(newName);
            if (existingOrganization != null && existingOrganization.Id != organization.Id)
            {
                throw new OrganizationAlreadyExistsException(newName);
            }

            organization.ChangeName(newName);
        }
    }
}

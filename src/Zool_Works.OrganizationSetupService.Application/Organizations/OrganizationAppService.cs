using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class OrganizationAppService : OrganizationSetupServiceAppService, IOrganizationAppService
    {
        private readonly IOrganizationRepository _orgRepository;
        private readonly OrganizationManager _orgManager;

        public OrganizationAppService(IOrganizationRepository orgRepository, OrganizationManager orgManager)
        {
            _orgRepository = orgRepository;
            _orgManager = orgManager;
        }
        #region CREATE
        public async Task<OrganizationDto> CreateAsync(CreateOrganizationDto input)
        {
            var org = await _orgManager.CreateAsync(
                input.Name,
                input.About,
                input.WebSite,
                input.TaxID,
                input.DateFormat,
                input.CompanyID
            );

            await _orgRepository.InsertAsync(org);

            return ObjectMapper.Map<Organization, OrganizationDto>(org);
        }
        #endregion
        #region DELETE
        public async Task DeleteAsync(Guid id)
        {
            await _orgRepository.DeleteAsync(id);
        }
        #endregion
        #region GET
        public async Task<OrganizationDto> GetAsync(Guid id)
        {
            var org = await _orgRepository.GetAsync(id);
            return ObjectMapper.Map<Organization, OrganizationDto>(org);
        }
        #endregion
        #region GetLIST
        public async Task<PagedResultDto<OrganizationDto>> GetListAsync(GetOrganizationListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Organization.Name);
            }

            var organizations = await _orgRepository.GetListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter
            );

            var totalCount = await AsyncExecuter.CountAsync(
                _orgRepository.WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    organization => organization.Name.Contains(input.Filter)
                )
            );

            return new PagedResultDto<OrganizationDto>(
                totalCount,
                ObjectMapper.Map<List<Organization>, List<OrganizationDto>>(organizations)
            );
        }
        #endregion
        #region UPDATE
        public async Task UpdateAsync(Guid id, UpdateOrganizationDto input)
        {
            var org = await _orgRepository.GetAsync(id);

            if (org.Name != input.Name)
            {
                await _orgManager.ChangeNameAsync(org, input.Name);
            }

            org.About = input.About;
            org.WebSite = input.WebSite;
            org.DateFormat = input.DateFormat;
            org.TaxID = input.TaxID;
            org.CompanyID = input.CompanyID;

            await _orgRepository.UpdateAsync(org);
        }
        #endregion
    }
}

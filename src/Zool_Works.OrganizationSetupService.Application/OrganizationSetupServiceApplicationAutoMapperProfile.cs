using AutoMapper;
using Zool_Works.OrganizationSetupService.Organizations;

namespace Zool_Works.OrganizationSetupService
{
    public class OrganizationSetupServiceApplicationAutoMapperProfile : Profile
    {
        public OrganizationSetupServiceApplicationAutoMapperProfile()
        {
            CreateMap<Organization, OrganizationDto>();            
        }
    }
}
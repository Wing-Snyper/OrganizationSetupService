using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class OrganizationDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string WebSite { get; set; }
        public string DateFormat { get; set; }
        public string TaxID { get; set; }
        public string CompanyID { get; set; }
    }
}

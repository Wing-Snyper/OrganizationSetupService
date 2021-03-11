using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class CreateOrganizationDto
    {
        [Required]
        [StringLength(OrganizationConsts.MaxNameLength)]
        public string Name { get; private set; }
        public string About { get; set; }
        public string WebSite { get; set; }
        public string DateFormat { get; set; }
        public string TaxID { get; set; }
        public string CompanyID { get; set; }
    }
}

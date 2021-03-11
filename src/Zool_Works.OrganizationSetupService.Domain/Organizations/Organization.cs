using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class Organization : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public string About { get; set; }
        public string WebSite { get; set; }
        public string DateFormat { get; set; }
        public string TaxID { get; set; }
        public string CompanyID { get; set; }
        
        /*gotta link the contact info, address, display settings, locale settings, also document thingy to handle the profile pic
         *(May be throw in a cover image support for an image slider. may be later ?).
         */

        private Organization()
        {

        }

        internal Organization(
            Guid id,
            [NotNull]string name,
            string about,
            string webSite,
            string dateFormat,
            string taxID,
            string companyID
            ): base(id)
        {
            SetName(name);
            About = about;
            WebSite = webSite;
            DateFormat = dateFormat;
            TaxID = taxID;
            CompanyID = companyID;
        }

        internal Organization ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull]string name)
        {
            Name = Check.NotNullOrWhiteSpace(
               name,
               nameof(name),
               maxLength: OrganizationConsts.MaxNameLength
            );
        }
    }
}

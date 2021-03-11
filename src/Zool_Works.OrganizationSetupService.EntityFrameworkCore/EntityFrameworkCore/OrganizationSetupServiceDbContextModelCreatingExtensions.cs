using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Zool_Works.OrganizationSetupService.Organizations;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    public static class OrganizationSetupServiceDbContextModelCreatingExtensions
    {
        public static void ConfigureOrganizationSetupService(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));            

            // Configure all entities here. 
            
            builder.Entity<Organization>(b =>
            {
                b.ToTable(OrgSetupSvcConsts.DbTablePrefix + "Organizations",
                    OrgSetupSvcConsts.DbSchema);

                b.ConfigureByConvention();

                b.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(OrganizationConsts.MaxNameLength);

                b.HasIndex(x => x.Name);
            });
        }
    }
}
﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;

namespace Zool_Works.OrganizationSetupService.Menus
{
    public class OrganizationSetupServiceWebHostMenuContributor : IMenuContributor
    {
        private readonly IConfiguration _configuration;

        public OrganizationSetupServiceWebHostMenuContributor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.User)
            {
                await ConfigureUserMenuAsync(context);
            }
        }

        private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<OrganizationSetupServiceResource>();
            var accountStringLocalizer = context.GetLocalizer<AccountResource>();

            var identityServerUrl = _configuration["AuthServer:Authority"] ?? "";

            context.Menu.AddItem(new ApplicationMenuItem("Account.Manage", accountStringLocalizer["ManageYourProfile"],  $"{identityServerUrl.EnsureEndsWith('/')}Account/Manage", icon: "fa fa-cog", order: 1000, null, "_blank"));
            context.Menu.AddItem(new ApplicationMenuItem("Account.Logout", l["Logout"], url: "~/Account/Logout", icon: "fa fa-power-off", order: int.MaxValue - 1000));

            return Task.CompletedTask;
        }
    }
}

import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'OrganizationSetupService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44339',
    redirectUri: baseUrl,
    clientId: 'OrganizationSetupService_App',
    responseType: 'code',
    scope: 'offline_access OrganizationSetupService',
  },
  apis: {
    default: {
      url: 'https://localhost:44339',
      rootNamespace: 'Zool_Works.OrganizationSetupService',
    },
    OrganizationSetupService: {
      url: 'https://localhost:44352',
      rootNamespace: 'Zool_Works.OrganizationSetupService',
    },
  },
} as Environment;

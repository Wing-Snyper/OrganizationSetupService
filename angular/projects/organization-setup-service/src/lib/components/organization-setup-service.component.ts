import { Component, OnInit } from '@angular/core';
import { OrganizationSetupServiceService } from '../services/organization-setup-service.service';

@Component({
  selector: 'lib-organization-setup-service',
  template: ` <p>organization-setup-service works!</p> `,
  styles: [],
})
export class OrganizationSetupServiceComponent implements OnInit {
  constructor(private service: OrganizationSetupServiceService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}

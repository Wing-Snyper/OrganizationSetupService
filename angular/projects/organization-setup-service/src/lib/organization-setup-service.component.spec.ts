import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { OrganizationSetupServiceComponent } from './organization-setup-service.component';

describe('OrganizationSetupServiceComponent', () => {
  let component: OrganizationSetupServiceComponent;
  let fixture: ComponentFixture<OrganizationSetupServiceComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ OrganizationSetupServiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrganizationSetupServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeLastSalarieComponent } from './employee-last-salarie.component';

describe('EmployeeLastSalarieComponent', () => {
  let component: EmployeeLastSalarieComponent;
  let fixture: ComponentFixture<EmployeeLastSalarieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeeLastSalarieComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeLastSalarieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

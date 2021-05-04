import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeSalaryListByPositionComponent } from './employee-salary-list-by-position.component';

describe('EmployeeSalaryListByPositionComponent', () => {
  let component: EmployeeSalaryListByPositionComponent;
  let fixture: ComponentFixture<EmployeeSalaryListByPositionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeeSalaryListByPositionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeSalaryListByPositionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

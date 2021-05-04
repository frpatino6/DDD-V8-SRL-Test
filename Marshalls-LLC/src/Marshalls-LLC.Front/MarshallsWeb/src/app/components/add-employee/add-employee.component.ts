import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { OfficeServices } from '../../services/officeServices';
import { PositionServices } from '../../services/positionServicesy';
import { DivisionServices } from '../../services/divisionServices';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { EmployeeServices } from '../../services/employee-salary-service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss'],
})
export class AddEmployeeComponent implements OnInit {
  constructor(
    private employeeService: EmployeeServices,
    private router: Router,
    private officeService: OfficeServices,
    private positionServices: PositionServices,
    private divisionService: DivisionServices
  ) {}
  dataSourceOffice: any;
  dataSourcePosition: any;
  dataSourceDivision: any;
  startDate = new Date(1990, 0, 1);
  selectedOffice: any;
  selectedPosition: any;
  selectedDivision: any;

  employeeForm = new FormGroup({
    employeeName: new FormControl(''),
    employeeSurname: new FormControl(''),
    employeeId: new FormControl(''),
    employeeCode: new FormControl(''),
    birthday: new FormControl(''),
    identificationNumber: new FormControl(''),
    grade: new FormControl(''),
    baseSalary: new FormControl(''),
    beginDate: new FormControl(''),
    officeId: new FormControl(''),
    positionId: new FormControl(''),
    divisionId: new FormControl(''),
    year: new FormControl(''),
    month: new FormControl(''),
    employeePeriods: new FormControl(''),

  });

  ngOnInit(): void {
    this.getAllOffices();
    this.getAllDivision();
    this.getAllPositions();
  }

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.employeeForm.value);

    this.employeeService.CreateEmployeeSalary(this.employeeForm.value).subscribe(
      (result) => {

        this.router.navigate(['']);
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }

  getAllOffices(): void {
    this.officeService.getAllOffice().subscribe(
      (result) => {
        this.dataSourceOffice = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  getAllPositions(): void {
    this.positionServices.getAllPositions().subscribe(
      (result) => {
        this.dataSourcePosition = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  getAllDivision(): void {
    this.divisionService.getAllDivision().subscribe(
      (result) => {
        this.dataSourceDivision = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
}

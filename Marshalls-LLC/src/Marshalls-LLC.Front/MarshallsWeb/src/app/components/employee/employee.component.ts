import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EmployeeServices } from 'src/app/services/employee-salary-service';
import * as _ from 'lodash';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss'],
})
export class EmployeeComponent implements OnInit {
  dataSource: any;
  displayedColumns = [
    'NombreCompleto',
    'Division',
    'Posicion',
    'FechaInicio',
    'Cumpleanos',
    'NumeroIdentificacion',
    'SalarioTotal',
    'actions',
  ];
  constructor(
    private employeeServices: EmployeeServices,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.employeeServices.getAllEmployees().subscribe(
      (result) => {
        this.dataSource = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  groupListByOffice(employeeCode, grade): void {
    this.router.navigate(['./salaries_employees', employeeCode, grade]);
  }

  getSameOfficeAndSameGrade(employeeCode): void {
    this.employeeServices.getReportByReporType(employeeCode, '1').subscribe(
      (result) => {
        this.dataSource = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  getSamePositionAndSameGrade(employeeCode): void {
    this.employeeServices.getReportByReporType(employeeCode, '3').subscribe(
      (result) => {
        this.dataSource = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
}

import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EmployeeServices } from 'src/app/services/employee-slaray-service';
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
  groupListByOffice(): void {
    localStorage.setItem('data', JSON.stringify(this.dataSource));
    this.router.navigate(['./salaries_employees']);
  }
}
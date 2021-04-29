import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';
import { EmployeeServices } from '../../services/employee-slaray-service';

@Component({
  selector: 'app-employee-salary-list',
  templateUrl: './employee-salary-list.component.html',
  styleUrls: ['./employee-salary-list.component.scss'],
})
export class EmployeeSalaryListComponent implements OnInit {
  dataSource: any;
  dataSourceGroupBy: any;
  displayedColumns = [
    'NombreCompleto',
    'Division',
    'Posicion',
    'FechaInicio',
    'Cumpleanos',
    'NumeroIdentificacion',
    'SalarioTotal',
  ];
  constructor(private employeeServices: EmployeeServices) {}

  ngOnInit(): void {
    this.groupListByOffice();
  }

  isGroup(index, item): boolean{
    return item.officeId;
  }

  groupListByOffice(): void {
    this.dataSource = JSON.parse(localStorage.getItem('data'));

    const dataSourceGroupBy = _(this.dataSource)
      .groupBy((x) => x.officeId)
      .map((value, key) => ({ officeId: key, employees: value }))
      .value();

    console.log(dataSourceGroupBy);
  }
}

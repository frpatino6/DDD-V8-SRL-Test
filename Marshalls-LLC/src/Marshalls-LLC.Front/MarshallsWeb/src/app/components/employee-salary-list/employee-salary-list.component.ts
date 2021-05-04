import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import * as _ from 'lodash';
import { EmployeeServices } from '../../services/employee-salary-service';
import { MatTableDataSource } from '@angular/material/table';
import { GroupEmployeeDTO } from 'src/app/models/group-employee';
import { EmployeeDTO } from '../../models/employee';

@Component({
  selector: 'app-employee-salary-list',
  templateUrl: './employee-salary-list.component.html',
  styleUrls: ['./employee-salary-list.component.scss'],
})
export class EmployeeSalaryListComponent implements OnInit {
  dataSource;
  displayedColumns = [
    'OfficeName',
    'NombreCompleto',
    'Grado',
    'Codigo',
    'FechaInicio',
    'Mes',
    'Ano',
    'SalarioBase'
  ];
  constructor(
    private employeeServices: EmployeeServices,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const employeeCode = this.route.snapshot.paramMap.get('employeeCode');
    const grade = this.route.snapshot.paramMap.get('grade');

    this.groupListByOffice(employeeCode, grade);
  }

  isGroup(index, item): boolean {
    return item.officeId;
  }

  groupListByOffice(employeeCode, grade): void {
    this.employeeServices
      .getReportGroupByType(employeeCode, '2', grade)
      .subscribe(
        (result) => {
           this.dataSource = new MatTableDataSource<GroupEmployeeDTO>(result);
           console.log(result);
        },
        (err: HttpErrorResponse) => {
          console.log(err);
        }
      );
  }
}

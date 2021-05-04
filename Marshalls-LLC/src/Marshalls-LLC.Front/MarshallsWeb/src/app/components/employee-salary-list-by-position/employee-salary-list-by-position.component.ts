import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { GroupEmployeeDTO } from 'src/app/models/group-employee';
import { EmployeeServices } from 'src/app/services/employee-salary-service';

@Component({
  selector: 'app-employee-salary-list-by-position',
  templateUrl: './employee-salary-list-by-position.component.html',
  styleUrls: ['./employee-salary-list-by-position.component.scss']
})
export class EmployeeSalaryListByPositionComponent implements OnInit  {
  dataSource;
  displayedColumns = [
    'PositionName',
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
      .getReportGroupByType(employeeCode, '4', grade)
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

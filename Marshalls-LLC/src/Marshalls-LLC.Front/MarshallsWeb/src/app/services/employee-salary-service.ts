import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { DOCUMENT } from '@angular/common';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { EmployeeDTO } from '../models/employee';
import { GroupEmployeeDTO } from '../models/group-employee';

@Injectable()
export class EmployeeServices {
  strUrl = '';
  header = new HttpHeaders();
  constructor(private http: HttpClient, @Inject(DOCUMENT) document: any) {
    this.header
      .set('Content-Type', 'application/json')
      .set('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, DELETE')
      .set('Allow', 'GET, POST, OPTIONS, PUT, DELETE')
      .set('Access-Control-Allow-Origin', '*');
    this.strUrl = `${environment.apiUrl}`;
  }

  public getAllEmployees(): Observable<EmployeeDTO> {
    const controler = 'Employee';
    const strlcl = this.strUrl + controler;
    return this.http.get<EmployeeDTO>(strlcl, { headers: this.header });
  }

  public getReportByReporType(
    employeeCode: string,
    reportType: string
  ): Observable<EmployeeDTO> {
    const params = new HttpParams().set('logNamespace', employeeCode);

    params.set('emplyeeCode', employeeCode);
    params.set('reportType', reportType);

    const controler = 'Employee';
    const strlcl =
      this.strUrl +
      controler +
      '?employeeCode=' +
      employeeCode +
      '&reportType=' +
      reportType;
    return this.http.get<EmployeeDTO>(strlcl, { headers: this.header, params });
  }

  public getReportGroupByType(
    employeeCode: string,
    reportType: string,
    grade: number
  ): Observable<GroupEmployeeDTO[]> {
    const params = new HttpParams().set('logNamespace', employeeCode);

    params.set('emplyeeCode', employeeCode);
    params.set('reportType', reportType);
    params.set('grade', grade.toString());

    const controler = 'Employee';
    const strlcl =
      this.strUrl +
      controler +
      '?employeeCode=' +
      employeeCode +
      '&reportType=' +
      reportType +
      '&grade=' +
      grade;
    return this.http.get<GroupEmployeeDTO[]>(strlcl, {
      headers: this.header,
      params,
    });
  }

  public CreateEmployeeSalary(
    employee: EmployeeDTO
  ): Observable<GroupEmployeeDTO[]> {
    const controler = 'Employee';
    const strlcl = this.strUrl + controler;
    return this.http.post<any[]>(strlcl, employee, {
      headers: this.header,
    });
  }
}

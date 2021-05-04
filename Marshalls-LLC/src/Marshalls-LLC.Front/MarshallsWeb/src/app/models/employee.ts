export interface EmployeeDTO {
  id: number;
  year: number;
  month: number;
  officeId: number;
  divisionId: number;
  positionId: number;
  employeeCode: string;
  employeeName: string;
  employeeSurname: string;
  grade: number;
  beginDate: string | null;
  birthday: string | null;
  identificationNumber: string;
  baseSalary: number;
  productionBonus: number;
  compensationBonus: number;
  commission: number;
  contributions: number;
  otherIncome: number;
  totalSalary: number;
  bono: number;
  divisionName: string;
  positionName: string;
  employeeInitialYear: number;
  employeeInitialMonth: number;
  employeePeriods: number;
}

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
    beginDateFormat: string | null;
    birthdayFormat: string | null;
    identificationNumber: string;
    baseSalary: number;
    productionBonus: number;
    compensationBonus: number;
    commission: number;
    contributions: number;
    otherIncome: number;
    totalSalary: number;
    divisionName: string;
    positionName: string;
}

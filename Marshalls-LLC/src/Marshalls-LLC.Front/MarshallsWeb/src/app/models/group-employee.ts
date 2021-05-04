import { EmployeeDTO } from './employee';
export interface GroupEmployeeDTO {
    parentId: string;
    listEmployee: EmployeeDTO[];
}


namespace Marshalls_LLC.Core.Services
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class EmployeeServices : IEmployeeServices
    {
        /// <summary>
        /// The salary repository
        /// </summary>
        private readonly IEmployeeRepository salaryRepository;

        /// <summary>
        /// The employee data validations
        /// </summary>
        private readonly IEmployeeDataValidations employeeDataValidations;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeServices"/> class.
        /// </summary>
        public EmployeeServices(IEmployeeRepository salaryRepository, IEmployeeDataValidations employeeDataValidations)
        {
            this.salaryRepository = salaryRepository;
            this.employeeDataValidations = employeeDataValidations;
        }

        /// <summary>
        /// Creates the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> CreateEmployee(Employee employee, int initMonth, int countPeriodo, int initYear)
        {
            if (this.employeeDataValidations.ValidateEmpoyeeData(employee))
            {
                return salaryRepository.CreateSalary(CreateSalaryPeriodo(employee, initMonth, countPeriodo, initYear));
            }
            else
                throw new Exception($"Error creando periodo para el empleado {employee.EmployeeName} {employee.EmployeeSurname}");
        }

        /// <summary>
        /// Creates the salary periodo.
        /// </summary>
        /// <returns>a List for each periodo employee</returns>
        private List<Employee> CreateSalaryPeriodo(Employee employee, int initMonth, int countPeriodo, int initYear)
        {
            int year = initYear;
            int month = initMonth;
            Employee employeePeriodo;

            List<Employee> listNewEmployeePeriodo = new List<Employee>();

            for (int i = 0; i < countPeriodo; i++)
            {
                if (month <= 12)
                {
                    employeePeriodo = (Employee)employee.Clone();
                    employeePeriodo.Month = month;
                    employeePeriodo.Year = year;
                    listNewEmployeePeriodo.Add(employeePeriodo);
                }
                month++;

                if (month > 12)
                {
                    year++;
                    month = 1;
                }
            }

            return listNewEmployeePeriodo;

        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public Task<List<Employee>> GetAll(string emplyeeCode = "", int? reportType = 0)
        {
            if (reportType > 5)
                throw new Exception("Opción de reporte no válido");

            if (!string.IsNullOrEmpty(emplyeeCode) && reportType.HasValue)
            {
                switch (reportType)
                {
                    case 1:
                        return salaryRepository.GetByOfficeAndGrade(emplyeeCode);
                    case 3:
                        return salaryRepository.GetByPositionAndGrade(emplyeeCode);
                    case 5:
                        return salaryRepository.GetLastEmployeeSalarie(emplyeeCode);
                }
            }
            return salaryRepository.GetAll();
        }

        /// <summary>
        /// Gets the employee group position.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        public List<EmployeePositionGroupDTO> GetEmployeeGroupPosition(int grade)
        {
            return salaryRepository.GetByAllPositionAndSameGrade(grade);
        }

        /// <summary>
        /// Gets the employee group office.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        public List<EmployeePositionGroupDTO> GetEmployeeGroupOffice(int grade)
        {
            return salaryRepository.GetByAllOfficeBySameGrade(grade);
        }
    }
}

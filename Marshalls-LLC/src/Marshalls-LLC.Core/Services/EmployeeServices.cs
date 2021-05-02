

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
        public Task<int> CreateEmployee(Employee employee)
        {
            if (this.employeeDataValidations.ValidateEmpoyeeData(employee))
            {
                return salaryRepository.CreateSalary(employee);
            }
            return null;
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

        public List<EmployeePositionGroupDTO> GetEmployeeGroupPosition(int grade)
        {
            return salaryRepository.GetByAllPositionAndSameGrade(grade);
        }

        public List<EmployeePositionGroupDTO> GetEmployeeGroupOffice(int grade)
        {
            return salaryRepository.GetByAllOfficeBySameGrade(grade);
        }
    }
}



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
        public Task<List<Employee>> GetAll()
        {
            return salaryRepository.GetAll();
        }
      

        /// <summary>
        /// Gets the by all office by same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        public Task<List<Employee>> GetByAllOfficeBySameGrade(int grade)
        {
            return salaryRepository.GetByAllOfficeBySameGrade(grade);
        }

        /// <summary>
        /// Gets the by all puestoy same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Employee>> GetByAllPuestoySameGrade(int grade)
        {
            return salaryRepository.GetByAllPuestoySameGrade(grade);
        }

        /// <summary>
        /// Gets the by position and grade.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Employee>> GetByPositionAndGrade(int position, int grade)
        {
            return salaryRepository.GetByPositionAndGrade(position, grade);
        }

        /// <summary>
        /// Gets the by ofice and grade.
        /// </summary>
        /// <param name="office">The office.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        public Task<List<Employee>> GetByOfficeAndGrade(int office, int grade)
        {
            return salaryRepository.GetByOfficeAndGrade(office, grade);
        }
    }
}



namespace Marshalls_LLC.Core.Interfaces
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeRepository
    {
        /// <summary>
        /// Creates the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        Task<int> CreateSalary(Employee salary);

        /// <summary>
        /// Gets the full name of the employee by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sureName">Name of the sure.</param>
        /// <returns></returns>
        int GetEmployeeByFullName(string name, string sureName);

        /// <summary>
        /// Gets the period month year by employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sureName">Name of the sure.</param>
        /// <returns></returns>
        int GetPeriodMonthYearByEmployee(int id, int month, int year);

        /// <summary>
        /// Gets the specified employee dto.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        Task<List<Employee>> Get(EmployeeDTO employeeDTO);

        Task<Employee> GetById(string employeeCode);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        Task<List<Employee>> GetAll();

        /// <summary>
        /// Gets the by ofice and grade.
        /// </summary>
        /// <param name="office">The office.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByOfficeAndGrade(string employeeCode);

        /// <summary>
        /// Gets the by position and grade.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByPositionAndGrade(string employeeCode);

        /// <summary>
        /// Gets the by all office by same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByAllOfficeBySameGrade(string employeeCode);

        /// <summary>
        /// Gets the by all puestoy same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByAllPuestoySameGrade(string employeeCode);

    }
}

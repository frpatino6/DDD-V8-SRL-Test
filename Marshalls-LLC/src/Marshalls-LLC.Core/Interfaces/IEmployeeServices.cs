

namespace Marshalls_LLC.Core.Interfaces
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeServices
    {
        /// <summary>
        /// Creates the employee.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        Task<int> CreateEmployee(Employee salary);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        Task<List<Employee>> GetAll(string emplyeeCode = "", int? reportType = 0);

        /// <summary>
        /// Gets the employee group position.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <param name="emplyeeCode">The emplyee code.</param>
        /// <returns></returns>
        List<EmployeePositionGroupDTO> GetEmployeeGroupPosition(int grade);

        /// <summary>
        /// Gets the employee group office.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <param name="emplyeeCode">The emplyee code.</param>
        /// <returns></returns>
        List<EmployeePositionGroupDTO> GetEmployeeGroupOffice(int grade);

    }
}

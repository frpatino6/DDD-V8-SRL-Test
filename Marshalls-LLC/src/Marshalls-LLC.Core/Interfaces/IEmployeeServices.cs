

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
        /// Gets the specified employee dto.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        Task<List<Employee>> Get(EmployeeDTO employeeDTO);

    }
}

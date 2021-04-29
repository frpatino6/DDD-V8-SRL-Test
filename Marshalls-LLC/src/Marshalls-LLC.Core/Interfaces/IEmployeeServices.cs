

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
        /// Gets the by ofice and grade.
        /// </summary>
        /// <param name="office">The office.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByOfficeAndGrade(int office, int grade);

        /// <summary>
        /// Gets the by position and grade.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByPositionAndGrade(int position, int grade);

        /// <summary>
        /// Gets the by all office by same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByAllOfficeBySameGrade( int grade);

        /// <summary>
        /// Gets the by all puestoy same grade.
        /// </summary>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        Task<List<Employee>> GetByAllPuestoySameGrade(int grade);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        Task<List<Employee>> GetAll();

    }
}

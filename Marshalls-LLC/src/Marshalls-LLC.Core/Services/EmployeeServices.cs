

namespace Marshalls_LLC.Core.Services
{
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using System;
    using System.Threading.Tasks;

    public class EmployeeServices : IEmployeeServices
    {
        /// <summary>
        /// The salary repository
        /// </summary>
        private readonly IEmployeeRepository salaryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeServices"/> class.
        /// </summary>
        public EmployeeServices(IEmployeeRepository salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }

        /// <summary>
        /// Determines whether [is valid salary] [the specified salary].
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns>
        ///   <c>true</c> if [is valid salary] [the specified salary]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidSalary(Employee salary)
        {
            return true;
        }

        /// <summary>
        /// Creates the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> CreateSalary(Employee salary)
        {
            if (this.IsValidSalary(salary)) {
                salaryRepository.CreateSalary(salary);
            }

            throw new NotImplementedException();
        }
    }
}

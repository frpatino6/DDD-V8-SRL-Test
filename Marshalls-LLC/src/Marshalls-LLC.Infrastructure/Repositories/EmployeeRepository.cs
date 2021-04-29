

namespace Marshalls_LLC.Infrastructure.Repositories
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Marshalls_LLC.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Creates the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> CreateSalary(Employee employee)
        {
            using (var context = DbContextFactory.Create())
            {
                context.Employee.Add(employee);
                return await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Gets the specified employee dto.
        /// </summary>
        /// <param name="employeeDTO">The employee dto.</param>
        /// <returns></returns>
        public async Task<List<Employee>> Get(EmployeeDTO employeeDTO)
        {
            IQueryable<Employee> query = DbContextFactory.Create().Employee;

            if (employeeDTO.OfficeId > 0)
            {
                query = query.Where(e => e.OfficeId.Equals(employeeDTO.OfficeId));
            }

            if (employeeDTO.Grade > 0) {
                query = query.Where(e => e.Grade.Equals(employeeDTO.Grade));
            }

            if (employeeDTO.PositionId > 0)
            {
                query = query.Where(e => e.Grade.Equals(employeeDTO.Grade));
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// Gets the full name of the employee by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sureName">Name of the sure.</param>
        /// <returns></returns>
        public int GetEmployeeByFullName(string name, string sureName)
        {
            using (var context = DbContextFactory.Create())
            {
                return context.Employee.Select(x => AppDbContext.Quantity_Of_Employee_By_Name(name, sureName)).FirstOrDefault();
            }

        }

        /// <summary>
        /// Gets the period month year by employee.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public int GetPeriodMonthYearByEmployee(int id, int month, int year)
        {
            using (var context = DbContextFactory.Create())
            {
                return context.Employee.Select(x => AppDbContext.Quantity_Of_Salary_By_Period(id, month, year)).FirstOrDefault();
            }
        }
    }
}

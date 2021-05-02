

namespace Marshalls_LLC.Infrastructure.Repositories
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Marshalls_LLC.Infrastructure.Data;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using RandomNameGeneratorLibrary;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Employee Repository
    /// </summary>
    /// <seealso cref="Marshalls_LLC.Core.Interfaces.IEmployeeRepository" />
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
                employee.Id = 0;
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

            if (employeeDTO.Grade > 0)
            {
                query = query.Where(e => e.Grade.Equals(employeeDTO.Grade));
            }

            if (employeeDTO.PositionId > 0)
            {
                query = query.Where(e => e.Grade.Equals(employeeDTO.Grade));
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetAll()
        {
            using (var context = DbContextFactory.Create())
            {
                return await context.Employee.Include(i => i.Division).Include(i => i.Position).ToListAsync();
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="employeeCode">The employee code.</param>
        /// <returns></returns>
        public async Task<Employee> GetById(string employeeCode)
        {
            using (var context = DbContextFactory.Create())
            {
                return await context.Employee.Where(x => x.EmployeeCode.Equals(employeeCode)).FirstOrDefaultAsync();
            }
        }

        /// <summary>
        /// Gets the by all office by same grade.
        /// </summary>
        /// <param name="office">The office.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<Employee>> GetByAllOfficeBySameGrade(string employeeCode)
        {
            using (var context = DbContextFactory.Create())
            {
                var employee = await GetById(employeeCode);

                if (employee != null)
                {
                    var result = context.Employee
                        .Where(g => g.Grade.Equals(employee.Grade))
                        .GroupBy(e => e.OfficeId)
                        .Select(g => new { country = g.Key, count = g.Count() })
                        .ToDictionary(k => k.country, i => i.count);
                }

                return null;
            }
        }

        public async Task<List<Employee>> GetByAllPuestoySameGrade(string employeeCode)
        {
            using (var context = DbContextFactory.Create())
            {
                var employee = await GetById(employeeCode);

                if (employee != null)
                    return await context.Employee.Where(x => x.Grade.Equals(employee.Grade)).ToListAsync();

                return null;
            }
        }

        /// <summary>
        /// Gets the by ofice and grade.
        /// </summary>
        /// <param name="office">The office.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        public async Task<List<Employee>> GetByOfficeAndGrade(string employeeCode)
        {
            using (var context = DbContextFactory.Create())
            {
                var employee = await GetById(employeeCode);

                if (employee != null)
                {
                    var result = await context.Employee.Where(x => x.OfficeId.Equals(employee.OfficeId)
                       && x.Grade.Equals(employee.Grade)).Include(i => i.Position).Include(i => i.Division).ToListAsync();

                    return result;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets the by position and grade.
        /// </summary>
        /// <param name="emplyeeCode">The emplyee code.</param>
        /// <returns></returns>
        public async Task<List<Employee>> GetByPositionAndGrade(string emplyeeCode)
        {
            using (var context = DbContextFactory.Create())
            {
                var employee = await GetById(emplyeeCode);

                if (employee != null)
                {
                    var result = await context.Employee.Where(x => x.PositionId.Equals(employee.PositionId)
                    && x.Grade.Equals(employee.Grade)).Include(i => i.Position).Include(i => i.Division).ToListAsync();

                    return result;
                }

                return null;
            }
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
        /// Gets the employee same office grade.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Employee>> GetEmployeeSameOfficeGrade()
        {
            throw new Exception();
        }

        /// <summary>
        /// Gets the period month year by employee.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public int GetPeriodMonthYearByEmployee(string employeeCode, int month, int year)
        {
            using (var context = DbContextFactory.Create())
            {
                return context.Employee.Select(x => AppDbContext.Quantity_Of_Salary_By_Period(employeeCode, month, year)).FirstOrDefault();
            }
        }

        public Task<List<Employee>> GetLastEmployeeSalarie(string employeeCode)
        {
            var code = new SqlParameter("employeeCode", employeeCode);

            var result = DbContextFactory.Create().Employee.FromSqlRaw($"EXECUTE  [dbo].[Sp_Get_Last_Employee_Salary] @EmployeeCode", code).ToListAsync();
            return result;

        }
    }
}

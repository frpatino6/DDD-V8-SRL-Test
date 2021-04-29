

namespace Marshalls_LLC.Infrastructure.Repositories
{
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Marshalls_LLC.Infrastructure.Data;
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

        public async Task<List<Employee>> GetAll()
        {
            using (var context = DbContextFactory.Create())
            {
                return await context.Employee.ToListAsync();
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
            EmployeeSeedAsync();

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
        public int GetPeriodMonthYearByEmployee(int id, int month, int year)
        {
            using (var context = DbContextFactory.Create())
            {
                return context.Employee.Select(x => AppDbContext.Quantity_Of_Salary_By_Period(id, month, year)).FirstOrDefault();
            }
        }

        private async Task EmployeeSeedAsync()
        {
            var personGenerator = new PersonNameGenerator();
            var firstName = personGenerator.GenerateMultipleMaleFirstNames(18).ToList();
            var lastName = personGenerator.GenerateMultipleLastNames(18).ToList();
            long[] rangeSalary = new long[] { 2000, 2500, 3000, 3500, 4000, 5000, 7000, 9000 };
            int count = 0;

            Random r = new Random();

            for (int i = 1; i < firstName.ToList().Count; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    var month = j;
                    var year = 2020;
                    var office = r.Next(1, 3);
                    var division = r.Next(1, 2);
                    var position = r.Next(1, 3);
                    var grade = r.Next(6, 18);
                    var beginDate = DateTime.Now;
                    var bithday = new DateTime(r.Next(1960, 2001), r.Next(1, 12), r.Next(1, 27));
                    var identification = r.Next(0, 99999999);
                    var employeeCode = r.Next(1000, 99999);
                    var baseSalary = rangeSalary[r.Next(0, 7)];
                    var productionBonus = baseSalary * 10 / 100;
                    var compensationBonus = baseSalary * 5 / 100;
                    var commision = baseSalary * 1 / 100;
                    var contribution = baseSalary * 3 / 100;

                    var employee = new Employee()
                    {                        
                        BaseSalary = baseSalary,
                        BeginDate = beginDate,
                        Birthday = bithday,
                        Commission = commision,
                        CompensationBonus = compensationBonus,
                        Contributions = contribution,
                        DivisionId = division,
                        EmployeeCode = employeeCode.ToString(),
                        EmployeeName = firstName[i],
                        EmployeeSurname = lastName[i],
                        IdentificationNumber = identification.ToString(),
                        OfficeId = office,
                        PositionId = position,
                        ProductionBonus = productionBonus,
                        Year = year,
                        Month = month,
                        Grade = grade
                    };
                    try
                    {
                        await CreateSalary(employee);
                        count++;
                    }
                    catch (DbUpdateException ex)
                    {

                        throw;
                    }
                }

            }

        }
    }
}

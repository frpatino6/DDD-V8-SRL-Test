using NUnit.Framework;
using Marshalls_LLC.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marshalls_LLC.Core.Interfaces;
using Marshalls_LLC.Api.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Infrastructure.Repositories;
using Marshalls_LLC.Core.SharedKernel;

namespace Marshalls_LLC.Core.Services.Tests
{
    [TestFixture()]
    public class EmployeeTest
    {
        private IEmployeeServices employeeServices;

        [SetUp]
        public void SetUp()
        {

        }

        /// <summary>
        /// Creates the existing employee data.
        /// </summary>
        private static Employee createExistingEmployeeData()
        {
            return new Employee()
            {
                BaseSalary = 2500,
                BeginDate = DateTime.Now,
                Birthday = new DateTime(1970, 05, 20),
                Commission = 0,
                CompensationBonus = 0,
                Contributions = 0,
                DivisionId = 1,
                EmployeeCode = "27665",
                EmployeeName = "Frances",
                EmployeeSurname = "Kruss",
                Grade = 13,
                IdentificationNumber = "523647899",
                Month = 2,
                Year = 2021,
                OfficeId = 2,
                PositionId = 2,
                ProductionBonus = 0
            };
        }

        /// <summary>
        /// Creates the existing employee same year month data.
        /// </summary>
        /// <returns></returns>
        /// 
        private static Employee createExistingEmployeeSameYearMonthData()
        {
            return new Employee()
            {
                Id = 1,
                BaseSalary = 2500,
                BeginDate = DateTime.Now,
                Birthday = new DateTime(1970, 05, 20),
                Commission = 0,
                CompensationBonus = 0,
                Contributions = 0,
                DivisionId = 1,
                EmployeeCode = "5028",
                EmployeeName = "Frances",
                EmployeeSurname = "Kruss",
                Grade = 13,
                IdentificationNumber = "523647899",
                Month = 2,
                Year = 2020,
                OfficeId = 2,
                PositionId = 2,
                ProductionBonus = 0
            };
        }

        /// <summary>
        /// Creates the existing employee year error data.
        /// </summary>
        /// <returns></returns>
        /// 
        private static Employee createExistingEmployeeYearErrorData()
        {
            return new Employee()
            {
                Id = 1,
                BaseSalary = 2500,
                BeginDate = DateTime.Now,
                Birthday = new DateTime(1970, 05, 20),
                Commission = 0,
                CompensationBonus = 0,
                Contributions = 0,
                DivisionId = 1,
                EmployeeCode = "5028",
                EmployeeName = "Frances",
                EmployeeSurname = "Kruss",
                Grade = 13,
                IdentificationNumber = "523647899",
                Month = 2,
                Year = 0001,
                OfficeId = 2,
                PositionId = 2,
                ProductionBonus = 0
            };
        }

        /// <summary>
        /// Creates the existing employee month error data.
        /// </summary>
        /// <returns></returns>
        private static Employee createExistingEmployeeMonthErrorData()
        {
            return new Employee()
            {
                Id = 1,
                BaseSalary = 2500,
                BeginDate = DateTime.Now,
                Birthday = new DateTime(1970, 05, 20),
                Commission = 0,
                CompensationBonus = 0,
                Contributions = 0,
                DivisionId = 1,
                EmployeeCode = "5028",
                EmployeeName = "Frances",
                EmployeeSurname = "Kruss",
                Grade = 13,
                IdentificationNumber = "523647899",
                Month = 22,
                Year = 2020,
                OfficeId = 2,
                PositionId = 2,
                ProductionBonus = 0
            };
        }

        private static Employee createNewEmployeeSuccesData()
        {
            return new Employee()
            {
                Id = 0,
                BaseSalary = 2500,
                BeginDate = DateTime.Now,
                Birthday = new DateTime(1970, 05, 20),
                Commission = 0,
                CompensationBonus = 0,
                Contributions = 0,
                DivisionId = 1,
                EmployeeCode = "5028",
                EmployeeName = "Fernando",
                EmployeeSurname = "Rodriguez Patiño",
                Grade = 13,
                IdentificationNumber = "523647899",
                Month = 2,
                Year = 2020,
                OfficeId = 2,
                PositionId = 2,
                ProductionBonus = 0
            };
        }

        /// <summary>
        /// Creates the employee error same name test.
        /// </summary>
        [Test()]
        public void CreateEmployeeErrorSameNameTest()
        {
            Exception expectedException = null;

            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            try
            {
                employeeServices.CreateEmployee(createExistingEmployeeData());
                Assert.Fail();
            }
            catch (Exception ex)
            {

                expectedException = ex;
            }

            Assert.IsTrue(expectedException is Exception);
        }

        /// <summary>
        /// Creates the employee error same month year test.
        /// </summary>
        [Test()]
        public void CreateEmployeeErrorSameMonthYearTest()
        {
            Exception expectedException = null;

            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            try
            {
                employeeServices.CreateEmployee(createExistingEmployeeSameYearMonthData());
                Assert.Fail();
            }
            catch (Exception ex)
            {

                expectedException = ex;
            }

            Assert.IsTrue(expectedException is Exception);
        }

        /// <summary>
        /// Creates the employee error year test.
        /// </summary>
        [Test()]
        public void CreateEmployeeErrorYearTest()
        {
            Exception expectedException = null;

            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            try
            {
                employeeServices.CreateEmployee(createExistingEmployeeYearErrorData());
                Assert.Fail();
            }
            catch (Exception ex)
            {

                expectedException = ex;
            }

            Assert.IsTrue(expectedException is Exception);
        }

        /// <summary>
        /// Creates the employee error month test.
        /// </summary>
        [Test()]
        public async Task CreateEmployeeSuccesTestAsync()
        {

            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            var result = await employeeServices.CreateEmployee(createNewEmployeeSuccesData());
            Assert.AreEqual(1, result);
        }

        [Test()]
        public async Task GetAllTestAsync()
        {
            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            var result = await employeeServices.GetAll();

            Assert.IsTrue(result.Count > 0);
        }

        [Test()]
        public async Task GetAllReportTypeNotValidTestAsync()
        {
            Exception expectedException = null;

            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            try
            {
                var result = await employeeServices.GetAll("43201", 6);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.IsTrue(expectedException is Exception);
        }

        [Test()]
        public void GetEmployeeSameOfficeAndGrade()
        {
            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            var result = employeeServices.GetEmployeeGroupOffice(11);

            Assert.IsTrue(result.Count > 0);
        }

        [Test()]
        public  void GetEmployeeSamePositionAndGrade()
        {
            var services = new ServiceCollection();
            services.AddTransient<IEmployeeServices, EmployeeServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDataValidations, EmployeeDataValidations>();

            var serviceProvider = services.BuildServiceProvider();
            employeeServices = serviceProvider.GetService<IEmployeeServices>();

            var result = employeeServices.GetEmployeeGroupPosition(17);

            Assert.IsTrue(result.Count > 0);
        }

    }
}
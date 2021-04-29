using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Core.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace Marshalls_LLC.Core.SharedKernel
{
    public class EmployeeDataValidations : IEmployeeDataValidations
    {
        /// <summary>
        /// The salary repository
        /// </summary>
        private readonly IEmployeeRepository salaryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDataValidations"/> class.
        /// </summary>
        /// <param name="salaryRepository">The salary repository.</param>
        public EmployeeDataValidations(IEmployeeRepository salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }

        /// <summary>
        /// Determines whether [is valid employee] [the specified employee].
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        ///   <c>true</c> if [is valid employee] [the specified employee]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">
        /// Ya existe un empleado con el nombre {employee.EmployeeName} {employee.EmployeeSurname}
        /// or
        /// Ya existe un periodo creado para  el mes {employee.Month} y año {employee.Year}
        /// </exception>
        public bool ValidateEmpoyeeData(Employee employee)
        {
            // validates if there is an employee with the same full name
            var countResultEmployee = this.salaryRepository.GetEmployeeByFullName(employee.EmployeeName, employee.EmployeeSurname);

            if (countResultEmployee > 0)
            {
                throw new Exception($"Ya existe un empleado con el nombre {employee.EmployeeName} {employee.EmployeeSurname}");
            }

            // validates if employee have created a same period  
            var countResultSalaryPeriod = this.salaryRepository.GetPeriodMonthYearByEmployee(employee.Id, employee.Month, employee.Year);

            if (employee.Id > 0)
                if (countResultSalaryPeriod > 0)
                    throw new Exception($"Ya existe un periodo creado para  el mes {employee.Month} y año {employee.Year}");

            if (!IsValidYear(employee.Year))
            {
                throw new Exception($"El año {employee.Year} no es válido");
            }

            if (!IsValiMonth(employee.Month))
            {
                throw new Exception($"El mes {employee.Month} no es válido");
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is valid year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is valid year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsValidYear(int year)
        {
            Regex regex = new Regex(@"\d{4}");
            Match match = regex.Match(year.ToString());
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is vali month] [the specified month].
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns>
        ///   <c>true</c> if [is vali month] [the specified month]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsValiMonth(int month)
        {
            if (month >= 1 && month <= 12)
                return true;

            return false;
        }
    }
}

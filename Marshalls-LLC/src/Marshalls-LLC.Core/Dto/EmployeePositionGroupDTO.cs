

namespace Marshalls_LLC.Core.Dto
{
    using Marshalls_LLC.Core.Entities;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class EmployeePositionGroupDTO
    {
        /// <summary>
        /// Gets or sets the parent identifier. PositonId or OfficeId
        /// </summary>
        /// <value>
        /// The parent identifier.
        /// </value>
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets the list employee.
        /// </summary>
        /// <value>
        /// The list employee.
        /// </value>
        public List<EmployeeDTO> ListEmployee { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePositionGroupDTO"/> class.
        /// </summary>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="listEmployee">The list employee.</param>
        public EmployeePositionGroupDTO(string parentId, List<Employee> listEmployee)
        {
            this.ParentId = parentId;
            this.ListEmployee = listEmployee.Select(e => new EmployeeDTO
            {

                BaseSalary = e.BaseSalary,
                BeginDate = e.BeginDate,
                Birthday = e.Birthday,
                Commission = e.Commission,
                CompensationBonus = e.CompensationBonus,
                Contributions = e.Contributions,
                Division = e.Division,
                EmployeeCode = e.EmployeeCode,
                EmployeeName = e.EmployeeName,
                EmployeeSurname = e.EmployeeSurname,
                Grade = e.Grade,
                Id = e.Id,
                IdentificationNumber = e.IdentificationNumber,
                Month = e.Month,
                Office = e.Office,
                Position = e.Position,
                ProductionBonus = e.ProductionBonus,
                Year = e.Year
            }).ToList();
        }
    }
}

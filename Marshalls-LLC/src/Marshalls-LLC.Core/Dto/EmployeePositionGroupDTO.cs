

namespace Marshalls_LLC.Core.Dto
{
    using Marshalls_LLC.Core.Entities;
    using System.Collections.Generic;

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
        public int ParentId { get; set; }
        public List<Employee> ListEmployee{ get; set; }

        
        public EmployeePositionGroupDTO(int parentId, List<Employee> listEmployee)
        {
            this.ParentId = parentId;
            this.ListEmployee = listEmployee;
        }
    }
}

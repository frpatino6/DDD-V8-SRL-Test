
using Marshalls_LLC.Core.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marshalls_LLC.Core.Entities
{
    public  class Office: BaseEntity
    {
        [InverseProperty(nameof(Employee.Office))]
        public  ICollection<Employee> Employees { get; set; }
    }
}

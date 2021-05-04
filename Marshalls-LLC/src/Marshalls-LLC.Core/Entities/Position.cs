
namespace Marshalls_LLC.Core.Entities
{
    using Marshalls_LLC.Core.SharedKernel;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Position :BaseEntity
    {
        [InverseProperty(nameof(Employee.Position))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

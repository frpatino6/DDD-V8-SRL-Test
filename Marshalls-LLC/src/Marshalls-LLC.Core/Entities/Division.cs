
using Marshalls_LLC.Core.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marshalls_LLC.Core.Entities
{
    /// <summary>
    /// Divicion entity
    /// </summary>
    /// <seealso cref="Marshalls_LLC.Core.SharedKernel.BaseEntity" />
    public class Division : BaseEntity
    {
        [InverseProperty(nameof(Employee.Division))]
        public ICollection<Employee> Employees { get; set; }
    }
}

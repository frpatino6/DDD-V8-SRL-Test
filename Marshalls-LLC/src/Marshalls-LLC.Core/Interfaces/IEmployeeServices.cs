

namespace Marshalls_LLC.Core.Interfaces
{
    using Marshalls_LLC.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeServices
    {
        Task<int> CreateSalary(Employee salary);

    }
}

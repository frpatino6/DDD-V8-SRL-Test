using Marshalls_LLC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalls_LLC.Core.Interfaces
{
    public interface IOfficeServices
    {
        Task<List<Office>> GetOffices();
    }
}

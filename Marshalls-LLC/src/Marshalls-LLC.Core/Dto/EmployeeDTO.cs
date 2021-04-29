using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalls_LLC.Core.Dto
{
   public class EmployeeDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Grade { get; set; }
        public int PositionId { get; set; }
        public int OfficeId { get; set; }
    }
}

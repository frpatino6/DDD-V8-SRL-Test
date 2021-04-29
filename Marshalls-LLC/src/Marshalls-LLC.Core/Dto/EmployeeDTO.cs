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
        public decimal BaseSalary { get; set; }
        public decimal Commission { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Grade { get; set; }
        public int PositionId { get; set; }
        public int OfficeId { get; set; }
        public decimal ProductionBonus { get; set; }
        public decimal CompensationBonus { get; set; }
        public decimal Contributions { get; set; }
        public decimal OtherIncome
        {
            get
            {
                return ((this.BaseSalary + this.Commission) * 8 / 100) + Commission;
            }
        }
        public decimal TotalSalary
        {
            get
            {
                return this.BaseSalary + this.ProductionBonus + (CompensationBonus * 75 / 100) + OtherIncome - Contributions;
            }
        }
    }
}

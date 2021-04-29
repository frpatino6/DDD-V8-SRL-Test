using Marshalls_LLC.Core.Entities;
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
        public int OfficeId { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName => Division.Name;
        public Division Division { get; set; }
        public string PositionName => Position.Name;
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int Grade { get; set; }
        public DateTime? BeginDate { get; set; }
        public string BeginDateFormat
        {
            get
            {
                return string.Format("{0:dd/MM/yyyy}", BeginDate.Value);
            }
        }

        public string BirthdayFormat
        {
            get
            {
                return string.Format("{0:dd/MM/yyyy}", Birthday.Value);
            }
        }

        public DateTime? Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal ProductionBonus { get; set; }
        public decimal CompensationBonus { get; set; }
        public decimal Commission { get; set; }
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

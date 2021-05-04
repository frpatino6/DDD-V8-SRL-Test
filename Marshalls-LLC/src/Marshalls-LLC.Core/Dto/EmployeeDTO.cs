using Marshalls_LLC.Core.Entities;
using System;
using System.Text.Json.Serialization;

namespace Marshalls_LLC.Core.Dto
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OfficeId { get; set; }
        public string OfficeName => Office == null ? string.Empty : Office.Name;
        public int DivisionId { get; set; }
        public string DivisionName => Division == null ? string.Empty : Division.Name;
        [JsonIgnore]
        public Division Division { get; set; }
        public string PositionName => Position == null ? "" : Position.Name;
        [JsonIgnore]
        public Position Position { get; set; }
        [JsonIgnore]
        public Office Office { get; set; }
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
                if (BeginDate != null)
                    return string.Format("{0:dd/MM/yyyy}", BeginDate.Value);

                return string.Empty;
            }
        }

        public string BirthdayFormat
        {
            get
            {
                if (Birthday != null)
                    return string.Format("{0:dd/MM/yyyy}", Birthday.Value);

                return string.Empty;                
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
        public decimal Bono
        {
            get
            {
                return BaseSalary / 3;
            }
        }
        public int employeeInitialYear { get; set; }
        public int employeeInitialMonth { get; set; }
        public int employeePeriods { get; set; }
    }
}

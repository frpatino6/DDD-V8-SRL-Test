
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marshalls_LLC.Core.Entities
{
    /// <summary>
    /// Salary entity
    /// </summary>
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public Division Division { get; set; }
        public int DivisionId { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [MaxLength(10)]
        public string EmployeeCode { get; set; }
        [DefaultValue("")]
        [MaxLength(150)]
        public string EmployeeName { get; set; }
        [MaxLength(150)]
        [DefaultValue("")]
        public string EmployeeSurname { get; set; }
        [DefaultValue(0)]
        public int Grade { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? Birthday { get; set; }
        [MaxLength(10)]
        [DefaultValue(0)]
        public string IdentificationNumber { get; set; }
        [DefaultValue(0)]
        public decimal BaseSalary { get; set; }
        [DefaultValue(0)]
        public decimal ProductionBonus { get; set; }
        [DefaultValue(0)]
        public decimal CompensationBonus { get; set; }
        [DefaultValue(0)]
        public decimal Commission { get; set; }
        [DefaultValue(0)]
        public decimal Contributions { get; set; }       
    }
}

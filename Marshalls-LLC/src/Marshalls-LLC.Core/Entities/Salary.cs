
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marshalls_LLC.Core.Entities
{
    /// <summary>
    /// Salary entity
    /// </summary>
    public class Salary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public Office Office { get; set; }
        public Division Division { get; set; }
        public Position Position { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName  { get; set; }
        public string EmployeeSurname  { get; set; }
        public int Grade { get; set; }
        public DateTime  BeginDate{ get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public double BaseSalary  { get; set; }
        public double ProductionBonus { get; set; }
        public double CompensationBonus  { get; set; }
        public double Commission { get; set; }
        public double Contributions { get; set; }

    }
}




namespace Marshalls_LLC.Infrastructure.Data
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Marshalls_LLC.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using RandomNameGeneratorLibrary;

    /// <summary>
    /// AppDbContext
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var divisionOperation = new Division() { Id = 1, Name = "Operation" };
            var divisionManager = new Division() { Id = 2, Name = "Manager" };
            modelBuilder.Entity<Division>().HasData(new Division[] { divisionManager, divisionOperation });

            var positionCargoManager = new Position() { Id = 1, Name = "Cargo Manager" };
            var positionCargoHead = new Position() { Id = 2, Name = "Head of cargo" };
            var positionCargoAssistant = new Position() { Id = 3, Name = "Cargo assistant" };
            modelBuilder.Entity<Position>().HasData(new Position[] { positionCargoAssistant, positionCargoHead, positionCargoManager });


            var officeA = new Office() { Id = 1, Name = "A" };
            var officeB = new Office() { Id = 2, Name = "B" };
            var officeC = new Office() { Id = 3, Name = "C" };
            modelBuilder.Entity<Office>().HasData(new Office[] { officeA, officeB, officeC });
            

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId);

                entity.HasOne(d => d.Office)
               .WithMany(p => p.Employees)
               .HasForeignKey(d => d.PositionId);
            });
            //seed employee
            EmployeeSeedAsync(modelBuilder);

            // Set default datetime for BeginDate field
            modelBuilder.Entity<Employee>()
           .Property(b => b.BeginDate)
           .HasDefaultValue(DateTime.Now);

            // Set default datetime for BeginDate field
            modelBuilder.Entity<Employee>()
           .Property(b => b.Birthday)
           .HasDefaultValue(DateTime.MinValue);

            base.OnModelCreating(modelBuilder);
        }

        private void EmployeeSeedAsync(ModelBuilder modelBuilder)
        {
            var personGenerator = new PersonNameGenerator();
            var firstName = personGenerator.GenerateMultipleMaleFirstNames(18).ToList();
            var lastName = personGenerator.GenerateMultipleLastNames(18).ToList();
            long[] rangeSalary = new long[] { 2000, 2500, 3000, 3500, 4000, 5000, 7000, 9000 };
            int id = 1;

            Random r = new Random();

            for (int i = 1; i < firstName.ToList().Count; i++)
            {
                var employeeCode = r.Next(1000, 99999);
                var office = r.Next(1, 3);
                var division = r.Next(1, 2);
                var position = r.Next(1, 3);
                var grade = r.Next(6, 18);
                var beginDate = DateTime.Now;
                var bithday = new DateTime(r.Next(1960, 2001), r.Next(1, 12), r.Next(1, 27));
                var identification = r.Next(0, 99999999);
                var baseSalary = rangeSalary[r.Next(0, 7)];
                var productionBonus = baseSalary * 10 / 100;
                var compensationBonus = baseSalary * 5 / 100;
                var commision = baseSalary * 1 / 100;
                var contribution = baseSalary * 3 / 100;

                for (int j = 1; j <= 6; j++)
                {
                    var month = j;
                    int year = 2020;
                    modelBuilder.Entity<Employee>().HasData(new Employee
                    {
                        Id = id,
                        BaseSalary = baseSalary,
                        BeginDate = beginDate,
                        Birthday = bithday,
                        Commission = commision,
                        CompensationBonus = compensationBonus,
                        Contributions = contribution,
                        DivisionId = division,
                        EmployeeCode = employeeCode.ToString(),
                        EmployeeName = firstName[i],
                        EmployeeSurname = lastName[i],
                        IdentificationNumber = identification.ToString(),
                        OfficeId = office,
                        PositionId = position,
                        ProductionBonus = productionBonus,
                        Year = year,
                        Month = month,
                        Grade = grade
                    });
                    id++;
                }

            }

        }


        [DbFunction("Quantity_Of_Employee_By_Name", "dbo")]
        public static int Quantity_Of_Employee_By_Name(string firstName, string sureName)
        {
            throw new Exception();
        }

        [DbFunction("Quantity_Of_Salary_By_Period", "dbo")]
        public static int Quantity_Of_Salary_By_Period(string id, int month, int year)
        {
            throw new Exception();
        }


        public DbSet<Employee> Employee { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Position> Position { get; set; }

    }
}

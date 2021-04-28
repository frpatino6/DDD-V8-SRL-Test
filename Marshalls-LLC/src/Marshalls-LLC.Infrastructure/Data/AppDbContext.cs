


namespace Marshalls_LLC.Infrastructure.Data
{
    using System.Diagnostics.CodeAnalysis;
    using Marshalls_LLC.Core.Entities;
    using Microsoft.EntityFrameworkCore;

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

            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}

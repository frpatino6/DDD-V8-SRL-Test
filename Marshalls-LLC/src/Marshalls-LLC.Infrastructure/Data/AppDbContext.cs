


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

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Salary> Salary { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}

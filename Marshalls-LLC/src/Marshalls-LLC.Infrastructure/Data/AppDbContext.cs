


namespace Marshalls_LLC.Infrastructure.Data
{
    using System.Diagnostics.CodeAnalysis;
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
    }
}

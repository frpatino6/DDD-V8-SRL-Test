//-----------------------------------------------------------------------
// <copyright file="DbContextFactory.cs" company="TestDeveloper">
//     Copyright (c) TestDeveloper. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Marshalls_LLC.Infrastructure.Data
{

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// DbContextFactory class
    /// </summary>
    public static class DbContextFactory
    {
        /// <summary>
        /// The database context
        /// </summary>
        public static AppDbContext DbContext;

        /// <summary>
        /// Gets or sets the connection strings.
        /// </summary>
        /// <value>
        /// The connection strings.
        /// </value>
        public static string ConnectionStrings { get; set; }

        /// <summary>
        /// Sets the connection string.
        /// </summary>
        /// <param name="connStrs">The connection STRS.</param>
        public static void SetConnectionString(string connStrs)
        {
            ConnectionStrings = connStrs;
            Create();
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Create a db context</returns>
        public static AppDbContext Create()
        {
            DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

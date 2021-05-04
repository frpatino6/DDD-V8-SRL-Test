using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Core.Interfaces;
using Marshalls_LLC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalls_LLC.Infrastructure.Repositories
{
    /// <summary>
    /// Office Repository
    /// </summary>
    /// <seealso cref="Marshalls_LLC.Core.Interfaces.IOfficeRepository" />
    public class OfficeRepository : IOfficeRepository
    {
        /// <summary>
        /// Gets the offices.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Office>> GetOffices()
        {
            using (var context = DbContextFactory.Create())
            {
                return await context.Office.ToListAsync();
            }
        }
    }
}

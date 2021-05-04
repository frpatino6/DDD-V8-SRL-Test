

namespace Marshalls_LLC.Infrastructure.Repositories
{
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Marshalls_LLC.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Position Repository
    /// </summary>
    /// <seealso cref="Marshalls_LLC.Core.Interfaces.IPositionRepository" />
    public class PositionRepository : IPositionRepository
    {
        /// <summary>
        /// Gets the positions.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Position>> GetPositions()
        {
            using (var context = DbContextFactory.Create())
            {
                return await context.Position.ToListAsync();
            }
        }
    }
}

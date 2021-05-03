using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalls_LLC.Core.Services
{
    public class PositionServices : IPositionServices
    {
        /// <summary>
        /// The office repository
        /// </summary>
        private readonly IPositionRepository positionRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionServices"/> class.
        /// </summary>
        /// <param name="officeRepository">The office repository.</param>
        public PositionServices(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        /// <summary>
        /// Gets the positions.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Position>> GetPositions()
        {
            return await positionRepository.GetPositions();
        }
    }
}

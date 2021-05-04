

namespace Marshalls_LLC.Core.Services
{
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Division Services
    /// </summary>
    /// <seealso cref="Marshalls_LLC.Core.Interfaces.IDivisionServices" />
    public class DivisionServices : IDivisionServices
    {

        /// <summary>
        /// The division repository
        /// </summary>;
        private readonly IDivisionRepository divisionRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionServices"/> class.
        /// </summary>
        /// <param name="readonly"></param>
        public DivisionServices(IDivisionRepository divisionRepository)
        {
            this.divisionRepository = divisionRepository;
        }
        /// <summary>
        /// Gets the divisions.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<Division>> GetDivisions()
        {
            return await divisionRepository.GetDivisions();
        }
    }
}

using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalls_LLC.Core.Services
{
    public class OfficeServices : IOfficeServices
    {
        /// <summary>
        /// The office repository
        /// </summary>
        private readonly IOfficeRepository officeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="OfficeServices"/> class.
        /// </summary>
        /// <param name="officeRepository">The office repository.</param>
        public OfficeServices(IOfficeRepository officeRepository)
        {
            this.officeRepository = officeRepository;
        }

        /// <summary>
        /// Gets the offices.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<Office>> GetOffices()
        {
            return officeRepository.GetOffices();
        }
    }
}



namespace Marshalls_LLC.Api.Controllers
{
    using AutoMapper;
    using Marshalls_LLC.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {

        /// <summary>
        /// The office services
        /// </summary>
        private readonly IOfficeServices officeServices;

        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="OfficeController"/> class.
        /// </summary>
        /// <param name="officeServices">The office services.</param>
        /// <param name="mapper">The mapper.</param>
        public OfficeController(IOfficeServices officeServices, IMapper mapper)
        {
            this.officeServices = officeServices;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await this.officeServices.GetOffices();

                if (result.Count > 0)
                    return Ok(result);

                return NotFound();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

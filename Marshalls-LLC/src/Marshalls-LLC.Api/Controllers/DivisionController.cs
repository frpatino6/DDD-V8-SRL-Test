
namespace Marshalls_LLC.Api.Controllers
{
    using Marshalls_LLC.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    /// <summary>
    /// Division Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        /// <summary>
        /// The division services
        /// </summary>
        private readonly IDivisionServices divisionServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionController"/> class.
        /// </summary>
        /// <param name="divisionServices">The division services.</param>
        public DivisionController(IDivisionServices divisionServices)
        {
            this.divisionServices = divisionServices;
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
                var result = await this.divisionServices.GetDivisions();

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

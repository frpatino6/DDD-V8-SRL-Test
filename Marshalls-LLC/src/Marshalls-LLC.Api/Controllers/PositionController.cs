

namespace Marshalls_LLC.Api.Controllers
{
    using Marshalls_LLC.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    /// <summary>
    /// Position Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {

        /// <summary>
        /// The position services
        /// </summary>
        private readonly IPositionServices positionServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionController"/> class.
        /// </summary>
        /// <param name="positionServices">The position services.</param>
        public PositionController(IPositionServices positionServices)
        {
            this.positionServices = positionServices;
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
                var result = await this.positionServices.GetPositions();

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

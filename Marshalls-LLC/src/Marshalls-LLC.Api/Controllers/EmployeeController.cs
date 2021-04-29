

namespace Marshalls_LLC.Api.Controllers
{
    using AutoMapper;
    using Marshalls_LLC.Api.Mapper;
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        /// <summary>
        /// The employee services
        /// </summary>
        private readonly IEmployeeServices employeeServices;

        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employeeServices">The employee services.</param>
        public EmployeeController(IEmployeeServices employeeServices, IMapper mapper)
        {
            this.employeeServices = employeeServices;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeDTO value)
        {
            try
            {
                Employee newEmployee = new  Employee();

                newEmployee = mapper.Map<Employee>(value);
                var recordsAffected = await employeeServices.CreateEmployee(newEmployee);

                if (recordsAffected > 0)
                    return Ok(recordsAffected);
                else
                    return BadRequest("La operación no se ejecutó con éxito.");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

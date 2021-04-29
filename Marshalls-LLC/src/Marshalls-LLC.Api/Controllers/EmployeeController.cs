

namespace Marshalls_LLC.Api.Controllers
{
    using AutoMapper;
    using Marshalls_LLC.Api.Mapper;
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using Marshalls_LLC.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
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

        [HttpGet]
        public async Task<IActionResult> Get(string emplyeeCode = "", int? reportType = 0)
        {
            try
            {
                var allEmployees = await employeeServices.GetAll(emplyeeCode, reportType);
                var result = mapper.Map<IEnumerable<EmployeeDTO>>(allEmployees).ToList();

                if (result.Count > 0)
                    return Ok(result);
                else
                    return NotFound();
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeDTO value)
        {
            try
            {
                Employee newEmployee = new Employee();

                newEmployee = mapper.Map<Employee>(value);
                var recordsAffected = await employeeServices.CreateEmployee(newEmployee);

                if (recordsAffected > 0)
                    return Ok(recordsAffected);
                else
                    return BadRequest("La operación no se ejecutó con éxito.");
            }
            catch (DbUpdateException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

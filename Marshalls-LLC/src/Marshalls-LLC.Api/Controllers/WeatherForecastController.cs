using Marshalls_LLC.Core.Entities;
using Marshalls_LLC.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marshalls_LLC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEmployeeServices salaryServices;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEmployeeServices salaryServices)
        {
            _logger = logger;
            this.salaryServices = salaryServices;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var employee = new Employee();
            employee.EmployeeName = "Fernando";
            employee.EmployeeSurname = "Rodriguez";

            try
            {
                this.salaryServices.CreateEmployee(employee);
            }
            catch (DbUpdateException ex)
            {
                BadRequest(ex.InnerException);
            }
            catch (Exception)
            {

                throw;
            }

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

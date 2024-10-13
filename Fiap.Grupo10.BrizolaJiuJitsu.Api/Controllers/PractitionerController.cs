using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PractitionerController : ControllerBase
    {
        private readonly IPractitionerApplication _practitionerApplication;
        private readonly ILogger<PractitionerController> _logger;

        public PractitionerController(IPractitionerApplication practitionerApplication,
                                         ILogger<PractitionerController> logger)
        {
            _practitionerApplication = practitionerApplication;
            _logger = logger;
        }

        /// <summary>
        /// Requires authentication via token independent of Role
        /// </summary>
        /// <returns>Returns list of registered practitioners</returns>
        /// <response code="200">List of items retrieved successfully.</response>
        /// <response code="204">No items found.</response>
        /// <response code="401">You are not authorized to access this resource. Please log in and try again.</response>
        /// <response code="500">An error occurred while retrieving the items. Please try again later.</response>
        [HttpGet(Name = "GetPractitioner")]
        public async Task<IEnumerable<Practitioner>> Get()
        {
            try
            {            
                return await _practitionerApplication.GetAllAsync();
                //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                //{
                //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                //    TemperatureC = Random.Shared.Next(-20, 55),
                //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                //})
                //.ToArray();
            }
            catch (Exception)
            {
                throw ;
            }
        }

        [HttpPost("PostPractitioner")]
        public IActionResult PostInsertPractitioner([FromBody] Practitioner practitioner)
        {
            //await _practitionerApplication.GetAllAsync();
            return Ok(practitioner);
        }
    }
}

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
        /// <response code="401">You are not authorized to access this resource. Please log in and try again.</response>
        /// <response code="500">An error occurred while retrieving the items. Please try again later.</response>
        /// <response code="503">Service is currently unavailable. Please try again later.</response>
        [HttpGet(Name = "GetPractitioner")]
        public async Task<ActionResult<IEnumerable<Practitioner>>> Get()
        {
            try
            {
                _logger.LogInformation("Fetching all practitioners from the database.");

                var practitioners = await _practitionerApplication.GetAllAsync();

                return Ok(practitioners);

                //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                //{
                //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                //    TemperatureC = Random.Shared.Next(-20, 55),
                //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                //})
                //.ToArray();
            }
            catch (TimeoutException ex)
            {
                _logger.LogError(ex, "Database timeout while fetching practitioners.");
                return StatusCode(503, "Service is currently unavailable. Please try again later.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching practitioners from the database.");
                return StatusCode(500, "An internal server error occurred.");
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

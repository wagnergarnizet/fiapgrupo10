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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

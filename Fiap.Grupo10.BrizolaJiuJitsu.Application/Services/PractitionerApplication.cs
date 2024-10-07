using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Application;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Services;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Application.Services
{
    public class PractitionerApplication : IPractitionerApplication
    {
        private readonly IPractitionerService _practitionerService;

        public PractitionerApplication(IPractitionerService practitionerService)
        {
            _practitionerService = practitionerService;
        }

        public async Task<IEnumerable<Practitioner>> GetAllAsync()
            => await _practitionerService.GetAllAsync();
    }
}

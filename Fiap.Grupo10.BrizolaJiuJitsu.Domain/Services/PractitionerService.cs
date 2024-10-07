using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Repositories;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Services;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Services
{
    public class PractitionerService(IPractitionerRepository practitionerRepository) : IPractitionerService
    {
        private readonly IPractitionerRepository _practitionerRepository = practitionerRepository;

        public async Task<IEnumerable<Practitioner>> GetAllAsync()
            => await _practitionerRepository.GetAsync();        
    }
}

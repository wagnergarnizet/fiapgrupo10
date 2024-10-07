using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Services
{
    public interface IPractitionerService
    {
        Task<IEnumerable<Practitioner>> GetAllAsync();
    }
}
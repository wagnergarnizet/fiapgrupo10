using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Application
{
    public interface IPractitionerApplication
    {
        Task<IEnumerable<Practitioner>> GetAllAsync();
    }
}
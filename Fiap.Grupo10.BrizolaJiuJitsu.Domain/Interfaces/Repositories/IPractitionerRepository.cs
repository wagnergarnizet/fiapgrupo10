using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Repositories
{
    public interface IPractitionerRepository
    {
        Task<int> InsertAsync(Practitioner practitioner);

        Task<IEnumerable<Practitioner>> GetAsync();
    }
}
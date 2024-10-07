using Dapper;
using Dapper.Contrib.Extensions;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Repositories;
using System.Data;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Infrastructure.Repositories
{
    public class PractitionerRepository(IDbConnection dbConnection) : IPractitionerRepository
    {
        private readonly IDbConnection _dbConnection = dbConnection;

        public async Task<int> InsertAsync(Practitioner practitioner)
        {
            if (practitioner == null)
                return 0;

            var insertQuery = @"INSERT INTO Practitioner
                                (
                                    Id,
                                    FullName,
                                    BloodType
                                )
                                VALUES
                                (
                                    @Id,
                                    @FullName,
                                    @BloodType
                                )";

            var parametros = new DynamicParameters();
            parametros.Add("@Id", practitioner.Id, DbType.AnsiStringFixedLength);
            parametros.Add("@FullName", practitioner.Id, DbType.AnsiStringFixedLength);
            parametros.Add("@BloodType", practitioner.Id, DbType.AnsiStringFixedLength);

            return await _dbConnection.ExecuteAsync(insertQuery, parametros);
        }

        public async Task<IEnumerable<Practitioner>> GetAsync()
        {
            try
            {
                var result = await _dbConnection.GetAllAsync<Practitioner>();

                return result;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

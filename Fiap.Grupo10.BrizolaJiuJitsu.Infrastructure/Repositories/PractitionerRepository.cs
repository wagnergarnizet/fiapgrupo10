using Dapper;
using Dapper.Contrib.Extensions;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Entities;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Grupo10.BrizolaJiuJitsu.Infrastructure.Repositories
{
    public class PractitionerRepository : IPractitionerRepository
    {
        private readonly IDbConnection _dbConnection;

        public PractitionerRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> InsertAsync (Practitioner practitioner)
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
           => await _dbConnection.GetAllAsync<Practitioner>();       
    }
}

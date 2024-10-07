using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Repositories;
using Fiap.Grupo10.BrizolaJiuJitsu.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fiap.Grupo10.BrizolaJiuJitsu.CrossCutting
{
    public static class RepositoriesDependencyInjection
    {
        public static IServiceCollection AddRepositoriesDependency (this IServiceCollection service)
        {
            service.AddScoped<IPractitionerRepository, PractitionerRepository>();

            return service;
        }

        public static IServiceCollection AddDbDependency(this IServiceCollection service, string connectionString)
        {
            service.AddScoped<IDbConnection>((conexao) => new SqlConnection(connectionString));
            return service;
        }
    }
}

using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Services;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Grupo10.BrizolaJiuJitsu.CrossCutting
{
    public static class ServicesDependencyInjection
    {
        public static IServiceCollection AddServicesDependency(this IServiceCollection service)
        {
            service.AddScoped<IPractitionerService, PractitionerService>();

            return service;
        }
    }
}

using Fiap.Grupo10.BrizolaJiuJitsu.Application.Services;
using Fiap.Grupo10.BrizolaJiuJitsu.Domain.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Grupo10.BrizolaJiuJitsu.CrossCutting
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependency(this IServiceCollection service)
        {
            service.AddScoped<IPractitionerApplication, PractitionerApplication>();

            return service;
        }
    }
}

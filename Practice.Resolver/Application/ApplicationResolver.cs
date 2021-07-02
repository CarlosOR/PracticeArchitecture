using Microsoft.Extensions.DependencyInjection;
using Practice.Architecture.Application.Employes;
using Practice.Architecture.Application.Interfaces.Employes;

namespace Practice.Resolver.Application
{
    public static class ApplicationResolver
    {

        public static void AddApplicationServices(this IServiceCollection service)
        {
            service.AddScoped<IEmployeeApplicationService, EmployeeApplicationService>();
        }

    }
}

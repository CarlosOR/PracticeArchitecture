using Practice.Architecture.Domain.Users;
using Practice.Architecture.Domain.Employes;
using Microsoft.Extensions.DependencyInjection;
using Practice.Architecture.Domain.Interfaces.Users;
using Practice.Architecture.Domain.Interfaces.Employes;

namespace Practice.Resolver.Domain
{
    public static class DomainResolver
    {
        public static void AddDomainServices(this IServiceCollection service)
        {
            service.AddScoped<IEmployeeDomainService, EmployeeDomainService>();
            service.AddScoped<IUserDomainService, UserDomainService>();
        }
    }
}

using Practice.Architecture.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using Practice.Architecture.Persistence.Repositories;
using Practice.Architecture.Persistence.Infraestructure;
using Practice.Architecture.Persistence.Interfaces.Repositories;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;


namespace Practice.Resolver.Persistence
{
    public static class PersistenceResolver
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            //To use a sql connection use DbFactory, only can be uncomment one of them
            //service.AddScoped<IDbFactory, DbFactory>();
            //To use in memory DB use MemoryDbFactory, only can be uncomment one of them
            //If u decide use in memory DB also coment the dependeci inyection for ContructorConnection to no provide a connection string
            service.AddScoped<IDbFactory, MemoryDbFactory>();
            service.AddScoped<IRepository<User>, Repository<User>>();
            service.AddScoped<IRepository<Employee>, Repository<Employee>>();
        }
    }
}

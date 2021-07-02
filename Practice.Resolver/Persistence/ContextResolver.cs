

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;

namespace Practice.Resolver.Persistence
{
    public static class ContextResolver
    {
        public static void ResolveDbContext<TContext>(this IServiceCollection service) where TContext: DbContext
        {
            //If u decide use in memory DB also coment the dependeci inyection for ContructorConnection to no provide a connection string
            //service.AddScoped<IContructorConnection, IContructorConnection>();
            service.AddDbContext<TContext>( (serviceProvider, contextBuilder) =>
            {
                IContructorConnection connection = serviceProvider.GetRequiredService<IContructorConnection>();
                connection.ConfigureConnection(contextBuilder);
            });
        }

    }
}

using Microsoft.EntityFrameworkCore;

namespace Practice.Architecture.Persistence.Interfaces.Infraestructure
{
    public interface IContructorConnection
    {
        //U can get by params IServiceProvider if u need some service
        void ConfigureConnection(DbContextOptionsBuilder builder);
    }
}

using Microsoft.EntityFrameworkCore;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;

namespace Practice.Architecture.Persistence.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DbContext dbContext;

        public DbContext DbContext
        {
            get => dbContext ?? (dbContext = dbFactory.Init());
        }

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}

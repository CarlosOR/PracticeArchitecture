using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practice.Architecture.Persistence.Context;

namespace Practice.Architecture.Persistence.Infraestructure
{
    public class MemoryDbFactory : Disposable, IDbFactory
    {
        private PracticeContext DbContext;

        public PracticeContext Init()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            DbContextOptions<PracticeContext> options =
                new DbContextOptionsBuilder<PracticeContext>()
                .UseInMemoryDatabase("InMemoryDbname")
                .UseInternalServiceProvider(serviceProvider)
                .Options;


            return DbContext ?? (DbContext = new PracticeContext(options));
        }

        protected override void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }
    }
}

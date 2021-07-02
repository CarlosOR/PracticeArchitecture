using System;
using Practice.Architecture.Persistence.Context;

namespace Practice.Architecture.Persistence.Infraestructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PracticeContext DbContext;

        public DbFactory(PracticeContext practiceContext)
        {
            this.DbContext = practiceContext;
        }

        public PracticeContext Init()
        {

            return DbContext ?? (DbContext = new PracticeContext());
        }

        protected override void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }

    }

    public interface IDbFactory : IDisposable
    {
        PracticeContext Init();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Architecture.Persistence.Interfaces.Infraestructure
{
    public interface IContructorConnection
    {
        void ConfigureConnection(IServiceProvider serviceProvider, DbContextOptionsBuilder builder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;

namespace Practice.Architecture.Persistence.Infraestructure
{
    public class ContructorConnection : IContructorConnection
    {
        public void ConfigureConnection(DbContextOptionsBuilder builder)
        {

            if (!builder.IsConfigured)
            {
                //If ur proyect gonna use migration add MigrationsOptions otherwise , just add connection string
                builder.UseSqlServer("Here write the connection string to sqlServer", MigrationsOptions);
            }
        }

        private readonly Action<SqlServerDbContextOptionsBuilder> MigrationsOptions =
            options => options.MigrationsHistoryTable("NameMigrationTable", "Schema");
    }
}

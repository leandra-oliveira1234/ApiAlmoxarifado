using APIAlmoxarifado.NovaPasta1;
using System.Collections.Generic;

namespace APIAlmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
           =>
             optionBuilder.UseSqlServer(
                 @"Server= sql.bsite.net\MSSQL2016;" +
                 "Database=dbAlmoxarifado;" +
                 "User id=kainan_;" +
        "Password=1234"
        );

        public DbSet<Produto> Produto { get; set; }

        public ConexaoSQL(DbSet<Produto> produto)
        {
            Produto = produto;
        }

        public class DbSet<T>
        {
        }

        public class DbContextOptionsBuilder
        {
        }
    }

    public class DbContext
    {
    }
}
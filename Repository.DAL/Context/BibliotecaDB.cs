using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Context
{
    public class BibliotecaDB : DbContext
    {
        public BibliotecaDB() : base(@"data source=6daaf793-4cde-467e-b765-a6750106bf9e.sqlserver.sequelizer.com; initial catalog:db6daaf7934cde467eb765a6750106bf9e; integrated security=true; User Id=cwuckdmyqwjgyaee; password=6YXPEcEzLrjEkCyewjfmuRM6Kd5gLi5Fr8USG8icvwBg66ViBr2W47Wnk2dBgyWB;") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}

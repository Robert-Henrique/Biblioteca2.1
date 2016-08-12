namespace Repository.DAL.Migrations
{
    using Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.BibliotecaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.BibliotecaDB context)
        {

            context.Estados.AddOrUpdate(
                new Estado() { Nome = "Acre", UF = "AC" },
                new Estado() { Nome = "Alagoas", UF = "AL" },
                new Estado() { Nome = "Amazonas", UF = "AM" },
                new Estado() { Nome = "Amapá", UF = "AP" },
                new Estado() { Nome = "Bahia", UF = "BA" },
                new Estado() { Nome = "Ceará", UF = "CE" },
                new Estado() { Nome = "Distrito Federal", UF = "DF" },
                new Estado() { Nome = "Espírito Santo", UF = "ES" },
                new Estado() { Nome = "Goiás", UF = "GO" },
                new Estado() { Nome = "Maranhão", UF = "MA" },
                new Estado() { Nome = "Minas Gerais", UF = "MG" },
                new Estado() { Nome = "Mato Grosso do Sul", UF = "MS" },
                new Estado() { Nome = "Mato Grosso", UF = "MT" },
                new Estado() { Nome = "Pará", UF = "PA" },
                new Estado() { Nome = "Paraíba", UF = "PB" },
                new Estado() { Nome = "Pernambuco", UF = "PE" },
                new Estado() { Nome = "Piauí", UF = "PI" },
                new Estado() { Nome = "Paraná", UF = "PR" },
                new Estado() { Nome = "Rio de Janeiro", UF = "RJ" },
                new Estado() { Nome = "Rio Grande do Norte", UF = "RN" },
                new Estado() { Nome = "Rondônia", UF = "RO" },
                new Estado() { Nome = "Roraima", UF = "RR" },
                new Estado() { Nome = "Rio Grande do Sul", UF = "RS" },
                new Estado() { Nome = "Santa Catarina", UF = "SC" },
                new Estado() { Nome = "Sergipe", UF = "SE" },
                new Estado() { Nome = "São Paulo", UF = "SP" },
                new Estado() { Nome = "Tocantins", UF = "TO" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

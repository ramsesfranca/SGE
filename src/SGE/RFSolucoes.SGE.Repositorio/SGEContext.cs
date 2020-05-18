using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RFSolucoes.SGE.Repositorio.Configurations.Cadastros;
using System.IO;

namespace RFSolucoes.SGE.Repositorio
{
    public sealed class SGEContext : DbContext
    {
        public SGEContext()
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("SGEConnection"));
        }
    }
}

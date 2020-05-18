using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RFSolucoes.SGE.Dominio.Entidades.Cadastros;

namespace RFSolucoes.SGE.Repositorio.Configurations.Cadastros
{
    public class ProdutoConfiguration : BaseConfiguration<int, Produto>
    {
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(250)");
            builder.Property(p => p.CodigoInterno).IsRequired().HasColumnType("varchar(250)");

            base.Configure(builder);
        }
    }
}

using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_mrp.Data.Map
{
    public class ProductsMap : IEntityTypeConfiguration<ProductsModel>
    {
        public void Configure(EntityTypeBuilder<ProductsModel> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(x => x.nome)
                .HasColumnName("Nome")
                .IsRequired();

            builder.Property(x => x.tipo)
                .HasColumnName("Tipo")
                .IsRequired();

            builder.Property(x => x.codigo)
                .HasColumnName("codigo")
                .IsRequired();

            builder.Property(x => x.id_Maquina)
                .HasColumnName("ID_Maquina")
                .IsRequired();

            builder.Property(x => x.id_Funcionario)
                .HasColumnName("ID_Funcionario")
                .IsRequired();

            builder.Property(x => x.qntd)
                .HasColumnName("Qntd")
                .IsRequired();

            builder.Property(x => x.custo)
                .HasColumnName("Custo")
                .IsRequired();

        }
    }
}

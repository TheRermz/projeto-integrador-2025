//camila me da uma lais
using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_mrp;

public class InsumoMap : IEntityTypeConfiguration<InsumosModel>
{
    public void Configure(EntityTypeBuilder<InsumosModel> builder)
    {
        builder.ToTable("Insumos");
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
            .HasColumnName("Codigo")
            .IsRequired();

        builder.Property(x => x.qntd)
            .HasColumnName("Qntd")
            .IsRequired();

        builder.Property(x => x.custo)
            .HasColumnName("Custo")
            .IsRequired();

        builder.Property(x => x.custo)
            .HasColumnName("Custo")
            .IsRequired();

        builder.Property(x => x.id_fornecedor)
            .HasColumnName("ID_Fornecedor")
            .IsRequired();
    }
}

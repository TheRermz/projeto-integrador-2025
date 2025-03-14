using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_mrp.Data.Map
{
    public class MachineMap : IEntityTypeConfiguration<MachinesModel>
    {
        public void Configure(EntityTypeBuilder<MachinesModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.modelo).IsRequired();
            builder.Property(x => x.status);
            builder.HasOne(x => x.user)
                .WithMany()
                .HasForeignKey(x => x.idUser)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.serialNumber);
            builder.Property(x => x.CPH);
        }
    }
}

using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;

namespace api_mrp.Data
{
    public class MrpDBContext : DbContext
    {
        public MrpDBContext(DbContextOptions<MrpDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsModel>().ToTable("Produto");
            modelBuilder.Entity<InsumosModel>().ToTable("Insumos");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<MachinesModel> Machines { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<InsumosModel> Insumos { get; set; }

    }
}
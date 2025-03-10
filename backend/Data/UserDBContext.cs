using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;

namespace api_mrp.Data
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }

    }
}
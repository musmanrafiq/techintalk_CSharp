using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class SchoolDbContext : DbContext
    {
        // individual tables
        public DbSet<UserEntity> Users { get; set; }

        public SchoolDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

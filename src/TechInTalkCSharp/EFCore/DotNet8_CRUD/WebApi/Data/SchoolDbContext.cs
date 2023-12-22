using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class SchoolDbContext : DbContext
    {
        //User Entity table presentation
        public DbSet<UserEntity> Users { get; set; }

        public SchoolDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

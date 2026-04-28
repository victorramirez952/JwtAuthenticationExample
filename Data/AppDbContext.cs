using AuthJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthJWT.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}

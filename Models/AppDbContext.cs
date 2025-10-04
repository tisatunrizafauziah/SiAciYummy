using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace SiAciYummy.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}

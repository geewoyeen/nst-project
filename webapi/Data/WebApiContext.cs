using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> opt) : base(opt)
        {
            
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product>  Products { get; set; }
    }
}
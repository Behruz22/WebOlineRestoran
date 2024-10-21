using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Data;

public class WebDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Order> Orders { get; set; } 
    public DbSet<OrderItem> Items { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Payment> Payments { get; set; }
    //public DbSet<Person> People { get; set; }
    public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) { }
}

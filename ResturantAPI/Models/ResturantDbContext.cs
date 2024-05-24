using Microsoft.EntityFrameworkCore;

namespace ResturantAPI.Models;

public class ResturantDbContext : DbContext
{
    public ResturantDbContext(DbContextOptions<ResturantDbContext> options)
        : base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<FoodItem> FoodItems { get; set; }
    public DbSet<OrderMaster> OrderMasters { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
}

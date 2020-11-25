using Lenta.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lenta.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ManufacturingProcess> ManufacturingProcesses { get; set; }
        public DbSet<ManufacturingOrder> ManufacturingOrders { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
    }
}

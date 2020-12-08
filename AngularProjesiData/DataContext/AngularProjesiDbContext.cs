using AngularProjesiData.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AngularProjesiData.DataContext
{
   public class AngularProjesiDbContext : IdentityDbContext //IdentityDbContext:kullanıcı girişi şifremi unuttum gibi kısımları otomatik getiriyor
    {
        public AngularProjesiDbContext(DbContextOptions options) :base (options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}

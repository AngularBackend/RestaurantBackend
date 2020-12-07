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
    }
}

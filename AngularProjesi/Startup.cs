using AngularProjesiCommon.Data_Contracts;
using AngularProjesiData.DataContext;
using AngularProjesiData.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiData.DbModels;

namespace AngularProjesi
{
    public class Startup //Ana uygulamalarımız için,değişikler yapacağımız yeri geldi mi servisleri tanıtacağımız class
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AngularProjesiDbContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<ApplicationUser,IdentityRole >().AddDefaultTokenProviders().AddEntityFrameworkStores<AngularProjesiDbContext>();
            services.AddScoped<IApplicationUserBusinessEngine, IApplicationUserBusinessEngine>();
        }

        private Action<DbContextOptionsBuilder> UseSqlServer(string v)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AngularProjesi
{
    public class Program //Projemize ilk run dediðimizde ayaða kalkacak olan class  
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); /*Startup classýný çaðýrýyor.Startup classý projemizi ayaða
                                                         kaldýrmak için gerekli yetkinlikleri yüklüyor */      
                });
    }
}

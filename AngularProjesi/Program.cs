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
    public class Program //Projemize ilk run dedi�imizde aya�a kalkacak olan class  
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); /*Startup class�n� �a��r�yor.Startup class� projemizi aya�a
                                                         kald�rmak i�in gerekli yetkinlikleri y�kl�yor */      
                });
    }
}

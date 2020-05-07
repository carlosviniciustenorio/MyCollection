using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace MyCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {


            CreateHostBuilder(args).Build().Run();
        }

        private static void InsertLocations()
        {
            Locations l = new Locations();
            l.Place = 1;

            using (var contexto = new CollectionContext())
            {
                contexto.Locations.Add(l);
                contexto.SaveChanges();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

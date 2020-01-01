using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // Host is set up which will configure a server and a request processing pipeline.
            // CreateHostBuilder will set up an app with some defaults using .CreateDefaultBuilder
            // The latter will configure a web server called Kestrel.

            // By default ASP.Net Core app is hosted by in its own internal web server.
            // I also can access app over IIS, and that link is  also enabled by default behind the scenes here.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // Configuration of App
                });
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Required for deployment
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace session
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                // New file for integration
                .UseIISIntegration()
                .Build();

            host.Run();
        }
    }
}

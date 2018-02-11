using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace c_secure_string
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            /* ******************************************************************** */
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)  // References path of directory
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  // Loads json file
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true) 
                .AddEnvironmentVariables();  // Add specific environment variables
            Configuration = builder.Build();
            /*  ALL STANDARD FOR SETTING UP BUILDER OBEJCT WITH SPECIFIC RULES */
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /* **************************************************************************** */
            // Adding specific services to ensure loading of file.  Maos object piece to appsettings
            services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
            services.AddScoped<DbConnector>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

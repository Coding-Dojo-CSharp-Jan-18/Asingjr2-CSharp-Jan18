using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
// Add to allow for connection
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace appsettings
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddSession();
            services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
            //  Adding to be used in other class.....can't use in other classes unless static...scoped allows for use of object and passes it to class...allows for more loose coupling
            services.AddScoped<TrailFactory>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc();
            
        }

        /* ***************************************************************************************** */
        public IConfiguration Configuration{ get; private set;}


        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
            .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // public void ConfigureServices(IServiceCollection services)
        // {
        //     services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
        // }
        
    }
}

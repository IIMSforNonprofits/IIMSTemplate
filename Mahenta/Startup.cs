using System;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Mahenta.Data;
using Mahenta.Models;
using Mahenta.Models.Interfaces;
using Mahenta.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using React.AspNet;

namespace Mahenta
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // These add our connection strings for our databases
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UserDbContext")));
            services.AddDbContext<InvMgmtDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DataDbContext")));

            // This is for adding our Identity Context
            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            // Dependency Injection Setup for our Data Access Layers
            services.AddScoped<IUserManagementService, UserManagementService>();
            services.AddScoped<IDonorService, DonorService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IMetricService, MetricService>();
            services.AddScoped<ILogService, LogService>();

            services.AddCors();

            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName)
                .AddChakraCore();

            //Set up DI for Adding React to the application
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();

            // Build the intermediate service provider then return it
            services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseAuthentication();
            app.UseStaticFiles();
            //app.UseCors();

            // Initialise ReactJS.NET. Must be before static files.
            app.UseReact(config =>
            {
                config
                    .SetReuseJavaScriptEngines(true)
                    .SetLoadBabel(false)
                    .SetLoadReact(false)
                    .AddScriptWithoutTransform("~/components-bundle.generated.js");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{path?}", new { controller = "Home", action = "Index" });
            });
        }
    }
}

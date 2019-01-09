using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IIMStemplate.Data;
using IIMStemplate.Models;
using IIMStemplate.Models.Interfaces;
using IIMStemplate.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using React.AspNet;

namespace IIMStemplate
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
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // These add our connection strings for our databases
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IIMSUserDbContext")));
            services.AddDbContext<InventoryManagementDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IIMSDataDbContext")));

            // This is for adding our Identity Context
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();

            // Dependency Injection Setup for our Data Access Layers
            services.AddScoped<IUserManagementService, UserManagementService>();
            services.AddScoped<IDonorService, DonorService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IMetricService, MetricService>();
            services.AddScoped<ILogService, LogService>();

            //Set up DI for Adding React to the application
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();

            return services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Initialize React scripts
            app.UseReact(config =>
            {
                //Put serverside rendering components as well as
                //dependencies for react
                //config.AddScript("~/Scripts/here.jsx");
                // config.AddScript("~/javascript/eric.jsx");
            });

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NorthWind.NorthWindDB.BLL.Services;
using NorthWind.NorthWindDB.LogLayer;
using NorthWind.NorthWindDB.ORM;
using NorthWind.NorthWindDB.ORM.MsSqlServer;
using NorthWind.NorthWindDB.ORM.NpgSql;
using NorthWind.NorthWindDB.WebAPI.NorthWindApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScopedObjects();
            services.AddDbCreate<NpgSqlOperation>();
            services.AddHttpClient<NorthWindApiService>(option => option.BaseAddress = new Uri(Configuration["baseUrl"]));
            services.AddControllers();
            services.AddCors(options => options.AddDefaultPolicy(build => build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseLog();
            app.UseCors();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

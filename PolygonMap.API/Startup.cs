﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PolygonMap.API.Configurations;
using PolygonMap.Domain.ApiModels;
using PolygonMap.Domain.Entities;

namespace PolygonMap.API
{

    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddResponseCaching();
            services.AddMvc();

            services.ConfigureRepositories()
                .ConfigureSupervisor()
                .AddMiddleware()
                .ConfigureMapper()
                .AddCorsConfiguration()
                .AddConnection(Configuration)
                .AddAppSettings(Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowAll");
            app.UseStaticFiles();
            app.UseMvc(
                routes => routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}"));


        }
    }
}

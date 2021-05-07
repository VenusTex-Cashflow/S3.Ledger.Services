using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using T3.S3Ledger.Api.Data;
using T3.S3Ledger.Api.Data.Initializer;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.RegisterServices;

namespace T3.S3Ledger.Api
{
    public class Startup
    {
        public IConfiguration _configuration { get; }


        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            var registerServices = typeof(Startup).Assembly.ExportedTypes.Where(s =>
                typeof(IRegisterService).IsAssignableFrom(s) &&
                !s.IsInterface &&
                !s.IsAbstract).Select(Activator.CreateInstance)
                              .Cast<IRegisterService>()
                              .ToList();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.WithOrigins("http://www.venustex.com")
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });

            //services.AddControllers();

            registerServices.ForEach(service => service.RegisterServices(services, _configuration));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddApiVersioning();
            services.AddHealthChecks();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "S3 Ledger Service APIs",
                    Version = "v1",
                    Description = "Endpoints to manage Ledger service payments"
                });
            });

            //services.AddCors();

            services.AddSwaggerGenNewtonsoftSupport();
            services.AddMediatR(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(doc =>
            {
                doc.RouteTemplate = "api/s3ledger/swagger/{documentname}/swagger.json";
            });

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "api/s3ledger/swagger";
                c.SwaggerEndpoint("v1/swagger.json", "S3 Ledger: Service Payment API");
            });
            //app.UseCors(policy =>
            //    policy.WithOrigins("http://localhost:5000", "https://localhost:44318")
            //    .AllowAnyMethod()
            //    .WithHeaders(HeaderNames.ContentType, HeaderNames.Authorization)
            //    .AllowCredentials());

            //app.UseCors(policy =>
            //            policy.WithOrigins("http://localhost:8081", "https://localhost:44359")
            //            .AllowAnyMethod()
            //            .WithHeaders(HeaderNames.ContentType));
            app.UseCors();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

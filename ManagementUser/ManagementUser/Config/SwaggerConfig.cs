using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementUser.Api.Config
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddRegistration(this IServiceCollection service)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "ManagementUser.API.xml");
            service.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "User Management API V1", Version="1" });
                c.IncludeXmlComments(xmlPath);
            });
            return service;
        }

        public static IApplicationBuilder AddRegistration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "User Management API V1"));
            return app;
        }
    }
}

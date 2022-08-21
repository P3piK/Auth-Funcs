﻿using AuthFuncsService.Interface;
using AuthFuncsService.Service;

namespace AuthFuncsAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAuthorizationService), typeof(AuthorizationService));
        }
    }
}
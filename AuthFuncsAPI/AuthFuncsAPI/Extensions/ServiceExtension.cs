using AuthFuncsRepository.Entity;
using AuthFuncsService.Dto.Authorization;
using AuthFuncsService.Interface;
using AuthFuncsService.Service;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

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
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            services.AddScoped<IValidator<RegisterRequestDto>, RegisterRequestDtoValidator>();

            services.AddScoped<IAuthorizationService, AuthorizationService>();

        }
    }
}

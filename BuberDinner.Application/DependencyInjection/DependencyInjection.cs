using BuberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace BuberDinner.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication (this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}

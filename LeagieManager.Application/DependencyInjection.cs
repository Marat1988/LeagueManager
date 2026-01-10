using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace LeagueManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(config => config.RegisterServicesFromAssembly(currentAccembly));
            services.AddValidatorsFromAssembly(currentAccembly);
            return services;
        }
    }
}

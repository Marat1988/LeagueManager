
using Microsoft.Extensions.DependencyInjection;

namespace LeagieManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            return services;
        }
    }
}

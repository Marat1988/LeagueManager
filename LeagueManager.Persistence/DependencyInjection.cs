
using Microsoft.Extensions.DependencyInjection;

namespace LeagieManager.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            return services;
        }
    }
}

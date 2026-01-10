
using Microsoft.Extensions.DependencyInjection;

namespace LeagieManager.Persentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersentation(this IServiceCollection services)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            return services;
        }
    }
}

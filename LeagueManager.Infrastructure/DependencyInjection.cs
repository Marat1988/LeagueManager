
using LeagueManager.Application.Emails;
using LeagueManager.Application.Storage;
using LeagueManager.Infrastructure.Emails;
using LeagueManager.Infrastructure.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace LeagieManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            services.AddSingleton<IEmailService, SmtpEmailService>();
            services.AddSingleton<IFileStorageService, LocalFileStorageService>();
            return services;
        }
    }
}

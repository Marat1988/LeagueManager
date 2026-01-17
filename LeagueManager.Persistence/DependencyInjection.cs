
using LeagueManager.Application;
using LeagueManager.Domain.Clubs;
using LeagueManager.Persistence;
using LeagueManager.Persistence.Clubs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeagieManager.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var currentAccembly = typeof(DependencyInjection).Assembly;
            var connectionString = configuration.GetConnectionString("LeagueManager");

            services.AddScoped<ISqlConnectionFactory>(sp =>
                new SqlConnectionFactory(connectionString));



            services.AddDbContext<LeagueManagerDbContext>(options =>
                options.UseSqlServer(connectionString, sqlOptions => sqlOptions.MigrationsAssembly(currentAccembly)

            ));




            services.AddScoped<IClubRepository, ClubRepository>();

            return services;
        }
    }
}

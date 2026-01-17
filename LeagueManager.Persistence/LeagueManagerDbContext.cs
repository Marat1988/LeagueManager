using LeagueManager.Domain.Clubs;
using LeagueManager.Domain.Players;
using LeagueManager.Domain.Stadiums;
using Microsoft.EntityFrameworkCore;

namespace LeagueManager.Persistence
{
    public class LeagueManagerDbContext (
        DbContextOptions<LeagueManagerDbContext> options
        ): DbContext(options)
    {

        public DbSet<Club> Clubs => Set<Club>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Stadium> Stadiums => Set<Stadium>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }



    }
}

using LeagueManager.Domain.Players;

namespace LeagueManager.Persistence.Players
{
    public class PlayerRepository(LeagueManagerDbContext dbContext) : IPlayerRepository
    {
        public async Task AddAsync(Player player)
        {
            await dbContext.Players.AddAsync(player);
        }

        public async Task<Player> GetByIdAsync(Guid id)
        {
            return await dbContext.Players.FindAsync(id);
        }

        public async Task<int> CommitAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

    }
}

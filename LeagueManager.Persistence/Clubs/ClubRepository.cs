using LeagueManager.Domain.Clubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Persistence.Clubs
{
    public class ClubRepository(
        LeagueManagerDbContext dbContext
        ) : IClubRepository
    {
        public async Task AddAsync(Club club)
        {
            await dbContext.Clubs.AddAsync(club);
        }

        public async Task<int> CommitAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public async Task<Club> GetByIdAsync(Guid id)
        {
            return await dbContext.Clubs.FindAsync(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Clubs
{
    public interface IClubRepository
    {
        Task AddAsync(Club club);
        Task<Club> GetByIdAsync(Guid id);
        Task<int> CommitAsync();
    }
}

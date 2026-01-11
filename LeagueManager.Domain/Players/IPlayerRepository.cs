using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Players
{
    public interface IPlayerRepository
    {
        Task AddAsync(Player player);
        Task<Player> GetByIdAsync (Guid id);
        Task<int> CommitAsync();
    }
}

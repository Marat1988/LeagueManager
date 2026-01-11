using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Stadiums
{
    public interface IStadiumRepository
    {
        Task AddAsync(Stadium stadium);
        Task<Stadium> GetByIdAsync(Guid id);
        Task<int> CommitAsync();
    }
}

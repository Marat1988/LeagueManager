using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.States
{
    public interface IStateRepository
    {
        Task AddAsync(State state);
        Task<State> GetByIdAsync(Guid id);
        Task<int> CommitAsync();
    }
}

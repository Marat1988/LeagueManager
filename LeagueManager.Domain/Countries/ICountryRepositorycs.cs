using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Countries
{
    public interface ICountryRepositorycs
    {
        Task TaskAsync(Country country);
        Task<Country> GetByIdAsync(Guid id);
        Task<int> CommitAsync();
    }
}

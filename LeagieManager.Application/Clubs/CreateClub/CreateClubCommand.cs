using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.CreateClub
{
    public record CreateClubCommand(
        string Name,
        string PhotoUrl,
        string WebsiteUrl,
        Guid? CreatedBy) : ICommand<int>;
}

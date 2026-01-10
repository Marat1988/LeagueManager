using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.UpdateClub
{
    public record UpdateClubCommand
        (
            Guid Id,
            string Name,
            string PhotoUrl,
            string WebsiteUrl,
            Guid? UpdatedBy
        ) : ICommand;
}

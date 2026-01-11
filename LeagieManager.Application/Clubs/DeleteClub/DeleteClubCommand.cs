using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LeagueManager.Application.Clubs.DeleteClub
{
    public record DeleteClubCommand(
        Guid Id,
        Guid? UpdatedBy
        ) : ICommand<int>;
}

using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetClubDetails
{
    public record GetClubDetailsQuery(Guid CludId) : IQuery<GetClubDetailsDto>
    {
    }
}

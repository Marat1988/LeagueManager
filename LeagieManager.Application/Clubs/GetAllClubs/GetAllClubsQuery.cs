using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetAllClubs
{
    public record GetAllClubsQuery : IQuery<List<GetAllClubsDto>>
    {
    }
}

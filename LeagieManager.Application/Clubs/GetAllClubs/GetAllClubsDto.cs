using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetAllClubs
{
    public record GetAllClubsDto
        (
            Guid ClubId,
            string Name,
            string PhotoUrl,
            string WebsiteUrl
        )
    {
    }
}

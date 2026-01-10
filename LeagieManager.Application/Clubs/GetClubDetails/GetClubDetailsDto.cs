using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetClubDetails
{
    public record GetClubDetailsDto
        (
            Guid CludId,
            string Name,
            string PhotoUrl,
            string WebSiteUrl
        );
}

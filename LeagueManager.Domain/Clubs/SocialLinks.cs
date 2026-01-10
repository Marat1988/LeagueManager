using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Clubs
{
    public record SocialLinks(
        string FacebookUrl,
        string TwitterUrl, 
        string InstargamUrl,
        string YoutubeUrl) : IValueObject
    {
    }
}

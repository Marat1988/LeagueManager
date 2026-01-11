using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.SharedKernal
{
    public record SocialLinks(
        string FacebookUrl,
        string TwitterUrl,
        string InstagramUrl,
        string YoutubeUrl
        ) : IValueObject;
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Persentation.Controllers.Clubs
{
    public class UpdateClubRequest
        (
            string Name,
            string PhotoUrl,
            string WebsiteUrl
        )
    {
        public string Name { get; set; } = Name;
        public string PhotoUrl { get; set; } = PhotoUrl;
        public string WebsiteUrl { get; set;} = WebsiteUrl;
    }
}

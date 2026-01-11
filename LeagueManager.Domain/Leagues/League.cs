using LeagueManager.Domain.Clubs;
using LeagueManager.Domain.Matches;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Leagues
{
    public class League: BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int SeasonYear { get; private set; }
        public IList<Club> Clubs { get; private set; } = [];
        public IList<Match> Matches { get; private set; } = [];
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set ; }
    }
}

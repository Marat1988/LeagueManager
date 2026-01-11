using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Matches
{
    public class Match: BaseEntity, IAggregateRoot
    {
        public Guid? HomeClubId { get; private set; }
        public Guid? AwayClubId { get; private set; }
        public int? StadiumId { get; private set; }
        public DateTime? MatchDate { get; private set; }
        public MatchStatus Status { get; private set; }
        public MatchScore Score  { get; private set; }
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
    }
}

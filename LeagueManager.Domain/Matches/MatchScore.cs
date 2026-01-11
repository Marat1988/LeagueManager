using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Matches
{
    public record MatchScore
        (
            int HomeGoals,
            int AwayGoals
        ) : IValueObject;
}

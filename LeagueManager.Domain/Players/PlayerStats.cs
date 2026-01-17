using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Players
{
    public record PlayerStats(
        int Apperances,
        int Goals,
        int Assists        
        ): IValueObject
    {
    }
}

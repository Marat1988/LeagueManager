using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Players
{
    public record PlayerContract
        (
            Guid ClubId,
            DateTime? StartDate,
            DateTime? EndDate,
            int SalaryPerMonth
        ): IValueObject;
}

using LeagueManager.Domain.SharedKernal;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Stadiums
{
    public class Stadium : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int? Capacity { get; private set; }
        public int? BuiltYear { get; private set; }
        public int? PitchLength { get; private set; }
        public int? PitchWidth { get; private set; }
        public string PhotoUrl { get; private set; }
        public bool? IsDeleted { get; private set; }

        public Address Address { get; private set; }

    }
}

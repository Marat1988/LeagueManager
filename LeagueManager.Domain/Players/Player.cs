using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Players
{
    public class Player : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int? ShirtNo { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public int? HeightInCm { get; private set; }
        public string PhotoUrl { get; private set; }
        public string WebSiteUrl { get; private set; }
        public bool IsDeleted { get; private set; }

        public PlayerPosition Position { get; private set; }

        public PlayerStarts Starts { get; private set; }

        public PlayerContract Contract { get; private set; }


    }
}

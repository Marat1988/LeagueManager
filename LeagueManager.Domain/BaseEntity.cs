using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}

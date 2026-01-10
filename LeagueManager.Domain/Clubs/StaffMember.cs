using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Clubs
{
    public class StaffMember : BaseEntity
    {
        public string FullName { get; private set; }
        public Club Club { get; private set; }

        public StaffRole Role { get; private set; }
    }
}

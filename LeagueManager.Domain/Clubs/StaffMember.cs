using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Clubs
{
    public class StaffMember : BaseEntity
    {
        public string FullName { get; private set; }
        public StaffRole Role { get; private set; }
        public Guid? ClubId { get; private set; }
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
    }
}

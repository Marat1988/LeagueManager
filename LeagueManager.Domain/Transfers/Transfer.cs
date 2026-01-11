using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Transfers
{
    public class Transfer: BaseEntity, IAggregateRoot
    {
        public Guid PlayerId { get; private set;  }
        public Guid? FromClubId { get; private set; }
        public Guid? ToClubId { get; private set; }
        public decimal TransferFee {  get; private set; }
        public DateTime? TransferDate { get; private set; }
        public TransferStatus Status { get; private set; }
    }
}

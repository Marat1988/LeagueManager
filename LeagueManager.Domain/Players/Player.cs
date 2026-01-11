using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Players
{
    public class Player : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int? ShirtNo { get; private set; }
        public Guid? ClubId { get; private set; }
        public PlayerPosition Position { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public int HeightInCm { get; private set; }
        public string PhotoUrl { get; private set; }
        public string WebsiteUrl { get; private set; }
        public bool IsDeleted { get; private set; }
        public PlayerStats Stats { get; private set; }
        public PlayerContract Contract { get; private set; }
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set ; }

        private Player()
        {

        }

        private Player(
            string name,
            int shirtNo,
            string photoUrl,
            DateTime? birthDate,
            Guid? createdBy
            )
        {
            Id = Guid.NewGuid();
            Name = name;
            ShirtNo = shirtNo;
            PhotoUrl = photoUrl;
            BirthDate = birthDate;

            CreatedBy = createdBy;
            CreatedDate = DateTime.UtcNow;
        }

        public static Player Create(
            string name,
            int shirtNo,
            string photoUrl,
            DateTime? birthDate,
            Guid? createdBy
            )
        {
            return new Player(name, shirtNo, photoUrl, birthDate, createdBy);
        }

        public void Update(
            string name,
            int shirtNo,
            string photoUrl,
            DateTime? birthDate,
            Guid? updatedBy
            )
        {
            Name = name;
            ShirtNo = shirtNo;
            PhotoUrl = photoUrl;
            BirthDate = birthDate;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }

        public void MarkAsDeleted(Guid? updateBy)
        {
            IsDeleted = true;

            UpdatedBy = updateBy;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}

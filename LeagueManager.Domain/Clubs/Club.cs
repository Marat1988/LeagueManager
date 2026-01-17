using LeagueManager.Domain.Players;
using LeagueManager.Domain.SharedKernal;
using LeagueManager.Domain.Stadiums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Clubs
{
    public class Club : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string PhotoUrl { get; private set; }
        public int FoundedYear { get; private set; }
        public string WebSiteUrl { get; private set; }
        public bool? IsDeleted { get; private set; }
        public Address Address { get; private set; }
        public int? StadiumId { get; private set; }
        public Stadium Stadium { get; private set; }
        public SocialLinks SocialLinks { get; private set; }
        public IList<Player> Players { get; private set; } = [];
        public IList<StaffMember> StaffMembers { get; private set; } = [];
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate { get; private set ; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        private Club()
        {

        }

        private Club(
            string name,
            string photoUrl,
            string webSiteUrl,
            Guid? createdBy)
        {
            Id = Guid.NewGuid();

            Name = name;
            PhotoUrl = photoUrl;
            WebSiteUrl = webSiteUrl;

            CreatedBy = createdBy;
            CreatedDate = DateTime.UtcNow;
        }

        public static Club Create(
            string name,
            string photoUrl,
            string websiteUrl,
            Guid? createdBy)
        {
            return new Club(name, photoUrl, websiteUrl, createdBy);
        }

        public void Update(
            string name,
            string photoUrl,
            string websiteUrl,
            Guid? updatedBy
            )
        {
            Name = name;
            PhotoUrl = photoUrl;
            WebSiteUrl = websiteUrl;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }

        public void MarkAsDeleted(Guid? updatedBy)
        {
            IsDeleted = true;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }

        public void UpdateAddress(Address address)
        {
            Address = address;
        }

        public void UpdateSocialLinks(SocialLinks socialLinks)
        {
            SocialLinks = socialLinks;
        }

        public void AppPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

        public void AddStaffMember(StaffMember staffMember)
        {
            StaffMembers.Add(staffMember);
        }

        public void RemoveStaffMember(StaffMember staffMember)
        {
            StaffMembers.Remove(staffMember);
        }
    }
}

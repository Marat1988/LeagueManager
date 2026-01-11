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
        public string WebsiteUrl { get; private set; }
        public bool? IsDeleted { get; private set; }
        public SocialLinks Links { get; private set; }
        public Address Address { get; private set; }

        public List<Player> Players { get; private set; } = [];

        public List<StaffMember> StaffMembers { get; private set; } = [];

        public Stadium Stadium { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        private Club()
        {

        }

        private Club(
            string name,
            string photoUrl,
            int foundedYear,
            string websiteUrl)
        {
            Name = name;
            PhotoUrl = photoUrl;
            FoundedYear = foundedYear;
            WebsiteUrl = websiteUrl;
        }

        public static Club Create(
            string name,
            string photoUrl,
            int foundedYear,
            string websiteUrl
            )
        {
            return new Club(name, photoUrl, foundedYear, websiteUrl);
        }

        public void Update(
            string name,
            string photoUrl,
            string webSiteUrl,
            Guid? updatedBy
            )
        {
            Name = name;
            PhotoUrl = photoUrl;
            WebsiteUrl= webSiteUrl;
            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;  

        }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }

        public void UpdateAddress(Address address)
        {
            Address = address;
        }

        public void UpdateSocialLink(SocialLinks socialLinks)
        {
            Links = socialLinks;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }
    }
}

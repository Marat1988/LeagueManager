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
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate {  get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        private Stadium()
        {

        }


        private Stadium(
            string name,
            int? capacity,
            int? builtYear,
            int? pitchLength,
            int? pitchWidth,
            Guid? createdBy
            )
        {
            Id = Guid.NewGuid();

            Name = name;
            Capacity = capacity;
            BuiltYear = builtYear;
            PitchLength = pitchLength;
            PitchWidth = pitchWidth;

            CreatedBy = createdBy;
            CreatedDate = DateTime.UtcNow;
        }


        public static Stadium Create(
            string name,
            int? capacity,
            int? builtYear,
            int? pitchLength,
            int? pitchWidth,
            Guid? createdBy
            )
        {
            return new Stadium(name, capacity, builtYear, pitchLength, pitchWidth, createdBy);
        }

        public void Update(
            string name,
            int? capacity,
            int? builtYear,
            int? pitchLength,
            int? pitchWidth,
            Guid? updatedBy
            )
        {
            Name = name;
            Capacity = capacity;
            BuiltYear = builtYear;
            PitchLength = pitchLength;
            PitchWidth = pitchWidth;

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

    }
}

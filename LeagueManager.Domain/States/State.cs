using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.States
{
    public class State: BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string IsoCode { get; private set; }
        public Guid CountryId { get; private set; }
        public bool? IsDeleted { get; private set; }
        public Guid? CreatedBy { get; private set; }
        public DateTime? CreatedDate {  get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        private State()
        {

        }

        private State(
            string name,
            string isoCode, 
            Guid countryId,
            Guid? createdBy)
        {
            Id = Guid.NewGuid();

            Name = name;
            IsoCode = isoCode;
            CountryId = countryId;

            CreatedBy = createdBy;
            CreatedDate = DateTime.UtcNow;
        }

        public static State Create(
            string name,
            string isoCode,
            Guid countryId,
            Guid? createdBy
            )
        {
            return new State(
                name,
                isoCode,
                countryId,
                createdBy);
        }

        public void Update(
            string name,
            string isoCode,
            Guid countryId,
            Guid? updatedBy
            )
        {
            Name = name;
            IsoCode = isoCode;
            CountryId = countryId;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }

        public void MarkAsDeleted(Guid? updatedBy)
        {
            IsDeleted = true;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}

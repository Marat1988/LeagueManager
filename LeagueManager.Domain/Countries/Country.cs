using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.Countries
{
    public class Country : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set;  }
        public string TwoLetterIsoCode { get; private set; }
        public string ThreeLetterIsoCode { get; private set; }
        public string FlagUrl { get; private set; }
        public int? DisplayOrder { get; private set; }
        public bool? IsDeleted { get; private set; }
        public Guid? CreateBy { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public Guid? UpdatedBy { get; private set; }
        public DateTime? UpdatedDate { get; private set ; }

        private Country()
        {

        }

        private Country(
            string name,
            string twoLetterIsoCode,
            string threeLetterIsoCode,
            string flagUrl,
            int? displayOrder,
            Guid? createBy)
        {
            Id = Guid.NewGuid();
            TwoLetterIsoCode = twoLetterIsoCode;
            ThreeLetterIsoCode = threeLetterIsoCode;
            FlagUrl = flagUrl;
            DisplayOrder = displayOrder;
            CreateBy = createBy;
            CreatedDate = DateTime.UtcNow;
        }

        public static Country Cteate(
            string name,
            string twoLetterIsoCode,
            string threeLetterIsoCode,
            string flagUrl,
            int? displayOrder,
            Guid? createdBy
            )
        {
            return new Country(
                name,
                twoLetterIsoCode,
                threeLetterIsoCode,
                flagUrl,
                displayOrder,
                createdBy
                );
        }

        public void Update(
            string name,
            string twoLetterIsoCode,
            string threeLetterIsoCode,
            string flagUrl,
            int? displayOrder,
            Guid? updatedBy
            )
        {
            Name = name;
            TwoLetterIsoCode = twoLetterIsoCode;
            ThreeLetterIsoCode = threeLetterIsoCode;
            FlagUrl = flagUrl;
            DisplayOrder = displayOrder;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }

        public void MarkAsDeteled(Guid? updatedBy)
        {
            IsDeleted = true;

            UpdatedBy = updatedBy;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}

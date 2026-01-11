using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LeagueManager.Domain.SharedKernal
{
    public record Address : IValueObject
    {
        public string AddressLine1 { get; init; }
        public string AddressLine2 { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public Guid StateId { get; init; }
        public Guid CountryId { get; init; }
        public string Zipcode { get; init; }


        private Address(
            string addressLine1,
            string addressLine2,
            string street,
            string city,
            Guid stateId,
            Guid countryId,
            string zipcode
            )
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Street = street;
            City = city;
            StateId = stateId;
            CountryId = countryId;
            Zipcode = zipcode;
        }

        public static Address Cteate(
            string addressLine1,
            string addressLine2,
            string street,
            string city,
            Guid stateId,
            Guid countryId,
            string zipcode
            )
        {
            if (string.IsNullOrEmpty(zipcode))
            {
                return null;
            }

            return new Address(
                addressLine1,
                addressLine2,
                street,
                city,
                stateId,
                countryId,
                zipcode
                );
        }
    }
}

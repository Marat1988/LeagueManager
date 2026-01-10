using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Domain.SharedKernal
{
    public record Address : IValueObject
    {
        public string Street { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string Country { get; init; }
        public string Zipcode { get; init; }

        private Address(string street,
            string city,
            string state,
            string country,
            string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            Zipcode = zipcode;
        }

        public static Address Create(
            string street,
            string city,
            string state,
            string country,
            string zipcode)
        {
            if (string.IsNullOrEmpty(zipcode))
            {
                return null;
            }
            return new Address(street, city, state, country, zipcode);
        }


    }
}

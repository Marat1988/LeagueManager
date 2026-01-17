using LeagueManager.Domain.SharedKernal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueManager.Persistence.SharedKernal
{
    internal static class AddressConfiguration
    {
        public static void ConfigureAddress<T>(
            this OwnedNavigationBuilder<T, Address> builder)
            where T : class
        {
            builder.Property(a => a.AddressLine1)
                .HasMaxLength(50);

            builder.Property(a => a.AddressLine2)
                .HasMaxLength(50);

            builder.Property(a => a.Street)
                .HasMaxLength(50);

            builder.Property(a => a.City)
                .HasMaxLength(50);

            builder.Property(a => a.StateId);
            builder.Property(a => a.CountryId);

            builder.Property(a => a.Zipcode)
                .HasMaxLength(50);

        }
    }
}

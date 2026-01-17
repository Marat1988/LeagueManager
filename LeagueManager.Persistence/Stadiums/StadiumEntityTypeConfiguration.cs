using LeagueManager.Domain.Stadiums;
using LeagueManager.Persistence.SharedKernal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueManager.Persistence.Stadiums
{
    internal class StadiumEntityTypeConfiguration : IEntityTypeConfiguration<Stadium>
    {

        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            // -----------------------------------
            // Table
            // -----------------------------------
            builder.ToTable("Stadiums", "dbo");

            // -----------------------------------
            // Address (Value Object)
            // -----------------------------------
            builder.OwnsOne(x => x.Address, a => a.ConfigureAddress());

        }
    }
}

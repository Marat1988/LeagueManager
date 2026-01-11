using LeagueManager.Domain.Clubs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Persistence.Clubs
{
    public class ClubEntityTypeConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.ToTable("Clubs", "dbo");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.HasKey(c => c.Id)
                .HasName("PK_Clubs_Id")
                .IsClustered(true);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(p => p.PhotoUrl)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(p => p.WebSiteUrl)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(p => p.IsDeleted);

        }
    }
}

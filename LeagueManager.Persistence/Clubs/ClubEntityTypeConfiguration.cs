using LeagueManager.Domain.Clubs;
using LeagueManager.Persistence.SharedKernal;
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
            // ---------------------------------
            // TABLE
            // ---------------------------------

            builder.ToTable("Clubs", "dbo");

            // --------------------------------
            // Key
            // --------------------------------

            builder.HasKey(c => c.Id)
                .HasName("PK_Clubs_Id")
                .IsClustered(true);

            // --------------------------------
            // Properties
            // --------------------------------

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(p => p.PhotoUrl)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(p => p.WebSiteUrl)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(p => p.IsDeleted);

            builder.Property(x => x.CreatedBy);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.UpdatedBy);
            builder.Property(x => x.UpdatedDate);

            // ----------------------------------
            // Statidum (Oprional FK)
            // ----------------------------------
            builder.Property(x => x.StadiumId);

            builder.HasOne(x => x.Stadium)
                .WithMany()
                .HasForeignKey(x => x.StadiumId)
                .OnDelete(DeleteBehavior.Restrict);

            // -----------------------------------
            // Address (Value Object)
            // -----------------------------------


            builder.OwnsOne(x => x.Address, a => a.ConfigureAddress());


            // -----------------------------------
            // SocialLink (Value Object)
            // -----------------------------------
            builder.OwnsOne(x => x.SocialLinks, s => s.ConfigureSolicalLinks());


            // -----------------------------------
            // Relationships
            // -----------------------------------
            builder.HasMany(x => x.Players)
                .WithOne()
                .HasForeignKey("ClubId")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.StaffMembers)
                .WithOne()
                .HasForeignKey("ClubId")
                .OnDelete(DeleteBehavior.Restrict);

            // -----------------------------------
            // Query Filter (Sort Delete)
            // -----------------------------------
            builder.HasQueryFilter(x => !x.IsDeleted.HasValue || !x.IsDeleted.Value);



        }
    }
}

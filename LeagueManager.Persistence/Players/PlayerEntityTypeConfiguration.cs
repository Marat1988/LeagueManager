using LeagueManager.Domain.Players;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueManager.Persistence.Players
{
    public class PlayerEntityTypeConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players", "dbo");

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.HasKey(p => p.Id)
                .HasName("PK_Players_Id")
                .IsClustered();

            builder.Property(e => e.Name)
                .HasMaxLength(50);

            builder.Property(p => p.ShirtNo);

            builder.Property(p => p.PhotoUrl)
                .HasMaxLength(50);

            builder.Property(p => p.BirthDate);

            builder.Property(p => p.IsDeleted);

            //builder.HasOne(d => d.Club)
            //    .WithMany(p => p.Players)
            //    .HasForeignKey(d => d.ClubId)
            //    .HasConstraintName("FK_Players_ClubId_Clubs_Id");
        }
    }
}

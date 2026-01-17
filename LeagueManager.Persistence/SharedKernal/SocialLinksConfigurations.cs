using LeagueManager.Domain.SharedKernal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeagueManager.Persistence.SharedKernal
{
    internal static class SocialLinksConfigurations
    {
        public static void ConfigureSolicalLinks<T>(
            this OwnedNavigationBuilder<T, SocialLinks> builder)
            where T : class
        {
            builder.Property(s => s.FacebookUrl)
                .HasMaxLength(500)
                .HasColumnName("FacebookUrl");

            builder.Property(s => s.TwitterUrl)
                .HasMaxLength(500)
                .HasColumnName("TwitterUrl");

            builder.Property(s => s.InstagramUrl)
                .HasMaxLength(500)
                .HasColumnName("InstagramUrl");

            builder.Property(s => s.YoutubeUrl)
                .HasMaxLength(500)
                .HasColumnName("YoutubeUrl");
        }
    }
}

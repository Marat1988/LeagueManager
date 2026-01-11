using LeagueManager.Application.Abstractions;
using LeagueManager.Domain.Clubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.CreateClub
{
    public class CreateClubCommandHandler(
        IClubRepository clubRepository
        ) : ICommandHandler<CreateClubCommand, int>
    {
        public async Task<int> Handle(CreateClubCommand request, CancellationToken cancellationToken)
        {
            var club = Club.Create(
                request.Name,
                request.PhotoUrl,
                request.WebsiteUrl,
                request.CreatedBy
                );

            await clubRepository.AddAsync(club);
            return await clubRepository.CommitAsync();

        }
    }
}

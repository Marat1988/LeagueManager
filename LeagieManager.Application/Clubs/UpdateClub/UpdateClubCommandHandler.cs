using LeagueManager.Application.Abstractions;
using LeagueManager.Domain.Clubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.UpdateClub
{
    public class UpdateClubCommandHandler
        (
            IClubRepository clubRepository
        ) : ICommandHandler<UpdateClubCommand>
    {
        public async Task Handle(UpdateClubCommand request, CancellationToken cancellationToken)
        {
            var club = await clubRepository.GetByIdAsync(request.Id);
            club.Update(request.Name,
                request.PhotoUrl,
                request.WebsiteUrl,
                request.UpdatedBy
                );
            await clubRepository.CommitAsync();
        }
    }
}

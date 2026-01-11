using LeagueManager.Application.Abstractions;
using LeagueManager.Domain.Clubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.DeleteClub
{
    public class DeleteClubCommandHandler(
        IClubRepository clubRepository
        ) : ICommandHandler<DeleteClubCommand, int>
    {
        public async Task<int> Handle(DeleteClubCommand request, CancellationToken cancellationToken)
        {
            var club = await clubRepository.GetByIdAsync(request.Id);
            club.MarkAsDeleted(request.UpdatedBy);
            return await clubRepository.CommitAsync();
        }
    }
}

using Dapper;
using LeagueManager.Application.Abstractions;
using LeagueManager.Application.Clubs.GetAllClubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetClubDetails
{
    public class GetClubDetalsQueryHandler(
            ISqlConnectionFactory sqlConnectionFactory
        ) : IQueryHandler<GetClubDetailsQuery, GetClubDetailsDto>

    {
        public async Task<GetClubDetailsDto> Handle(GetClubDetailsQuery request, CancellationToken cancellationToken)
        {
            const string sql = @"SELECT
                                    Id,
                                    Name,
                                    PhotoUrl,
                                    WebSiteUrl
                                   FROM Clubs
                                   WHERE Id = @ClubId";
            using var connection = sqlConnectionFactory.GetOpenConnection();
            return await connection.QuerySingleAsync<GetClubDetailsDto>(sql, new { request.CludId} );
        }
    }
}

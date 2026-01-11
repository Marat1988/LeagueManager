using Dapper;
using LeagueManager.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Clubs.GetAllClubs
{
    public class GetAllClubsQueryHandler
        (
            ISqlConnectionFactory sqlConnectionFactory
        
        )  : IQueryHandler<GetAllClubsQuery, List<GetAllClubsDto>>
    {
        public async Task<List<GetAllClubsDto>> Handle(GetAllClubsQuery request, CancellationToken cancellationToken)
        {
            const string sql = @"SELECT
                                    Id,
                                    Name,
                                    PhotoUrl,
                                    WebSiteUrl
                                   FROM Clubs
                                   ORDER BY Name;";
            using var connection = sqlConnectionFactory.GetOpenConnection();
            return (await connection.QueryAsync<GetAllClubsDto>(sql, cancellationToken)).AsList();
        }
    }
}

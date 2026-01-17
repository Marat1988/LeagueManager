using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using LeagueManager.Application.Clubs.GetAllClubs;
using LeagueManager.Application.Clubs.GetClubDetails;
using LeagueManager.Application.Clubs.UpdateClub;
using LeagueManager.Application.Clubs.CreateClub;
using LeagueManager.Application.Clubs.DeleteClub;

namespace LeagueManager.Persentation.Controllers.Clubs
{
    [ApiController]
    [Route("[controller]")]
    public class ClubsController 
        (IMediator mediator): ControllerBase
    {

        [HttpGet]
        public async Task<List<GetAllClubsDto>> GetAllClubs()
        {
            return await mediator.Send(new GetAllClubsQuery());
        }

        [HttpGet("{clubId}")]
        [ProducesResponseType(typeof(GetClubDetailsDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetClubDetails([FromRoute] Guid clubId)
        {
            var club = await mediator.Send(new GetClubDetailsQuery(clubId));
            return Ok(club);
        }

        [HttpPut("{clubId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateClub([FromRoute] Guid clubId, [FromBody] UpdateClubRequest request)
        {
            await mediator.Send(new UpdateClubCommand(
                clubId,
                request.Name,
                request.PhotoUrl,
                request.WebsiteUrl,
                null
                ));
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateClub([FromBody] CreateClubRequest request)
        {
            await mediator.Send(new CreateClubCommand(
                request.Name,
                request.PhotoUrl,
                request.WebsiteUrl,
                null
                ));
            return Ok();
        }

        [HttpDelete("{clubId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteClub([FromRoute] Guid clubId)
        {
            await mediator.Send(new DeleteClubCommand(clubId, null));
            return Ok();
        }



    }
}

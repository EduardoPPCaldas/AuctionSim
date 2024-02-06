using AuctionSim.Application.Auctions;
using AuctionSim.Domain.Auctions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuctionController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCurrentAuction(
        [FromServices] IGetCurrentAuctionUseCase useCase,
        CancellationToken cancellationToken)
    {
        var auction = await useCase.ExecuteAsync(0, cancellationToken);

        return Ok(auction);
    }
}

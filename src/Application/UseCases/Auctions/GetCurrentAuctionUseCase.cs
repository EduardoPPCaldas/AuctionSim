using AuctionSim.Domain.Auctions;
using AuctionSim.Domain.Utils;
using Domain.Auctions.Repositories;

namespace AuctionSim.Application.Auctions;

[GenerateAutomaticInterface]
public class GetCurrentAuctionUseCase : IGetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _auctionRepo;

    public GetCurrentAuctionUseCase(IAuctionRepository auctionRepo)
    {
        _auctionRepo = auctionRepo;
    }

    public async Task<List<Auction>> ExecuteAsync(int id, CancellationToken cancellationToken)
    {
        return await _auctionRepo.Get(
            x => x.Starts >= DateTime.Now && x.Ends <= DateTime.Now,
            cancellationToken);
    }
}
using System.Linq.Expressions;
using AuctionSim.Domain.Auctions;

namespace Domain.Auctions.Repositories;

public interface IAuctionRepository
{
    Task<Auction?> Get(int id, CancellationToken cancellationToken = default);
    Task<List<Auction>> Get(Expression<Func<Auction, bool>> expression, CancellationToken cancellationToken = default);
}
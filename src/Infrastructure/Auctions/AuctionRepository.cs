using System.Linq.Expressions;
using AuctionSim.Domain.Auctions;
using AuctionSim.Infrastructure.Databases;
using Domain.Auctions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuctionSim.Infrastructure.Auctions;

public class AuctionRepository(AuctionSimDbContext dbContext) : IAuctionRepository
{
    private readonly AuctionSimDbContext _dbContext = dbContext;

    public async Task<Auction?> Get(int id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Auctions
            .Include(x => x.Items)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<Auction>> Get(Expression<Func<Auction, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Auctions
            .Where(expression)
            .ToListAsync(cancellationToken);
    }
}
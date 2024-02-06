using AuctionSim.Domain.Auctions;
using Microsoft.EntityFrameworkCore;

namespace AuctionSim.Infrastructure.Databases;

public class AuctionSimDbContext : DbContext
{
    public DbSet<Auction> Auctions => Set<Auction>();
    public AuctionSimDbContext(DbContextOptions<AuctionSimDbContext> opt) : base(opt)
    {
    }
}
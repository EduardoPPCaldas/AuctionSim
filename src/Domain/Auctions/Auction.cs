namespace AuctionSim.Domain.Auctions;

public class Auction
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required DateTime Starts { get; set; }
    public required DateTime Ends { get; set; }
    public List<Item> Items { get; set; } = [];
}
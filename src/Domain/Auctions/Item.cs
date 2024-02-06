using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionSim.Domain.Auctions;

[Table("Items")]
public class Item
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Brand { get; set; }
    public required int Condition { get; set; }
    public required decimal BasePrice { get; set; }
    public required int AuctionId { get; set; }
}
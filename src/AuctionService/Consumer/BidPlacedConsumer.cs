using AuctionService.Data;
using Contracts;
using MassTransit;

namespace AuctionService;

public class BidPlacedConsumer : IConsumer<BidPlace>
{
 private readonly AuctionDbContext _dbContext;
    public BidPlacedConsumer(AuctionDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Consume(ConsumeContext<BidPlace> context)
    {
       Console.WriteLine("--> Consuming bid placed");
       var auction = await _dbContext.Auctions.FindAsync(context.Message.AuctionId);
       if(auction.CurrentHighBid == null 
            || context.Message.BidStatus.Contains("Accepted")
            && context.Message.Amout > auction.CurrentHighBid)
            {
                auction.CurrentHighBid = context.Message.Amout;
                await _dbContext.SaveChangesAsync();
            }
    }
}

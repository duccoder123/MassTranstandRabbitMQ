using Contracts;
using MassTransit;
using MongoDB.Entities;

namespace SearchService;

public class BidPlacedConsumer : IConsumer<BidPlace>
{
    public async Task Consume(ConsumeContext<BidPlace> context)
    {
        Console.WriteLine("--> Consuming bid placed");
        var auction = await DB.Find<Item>().OneAsync(context.Message.AuctionId);
        if(context.Message.BidStatus.Contains("Accepted") 
        && context.Message.Amout > auction.CurrentHighBid){
                auction.CurrentHighBid= context.Message.Amout;
                await auction.SaveAsync();
        }
    }
}

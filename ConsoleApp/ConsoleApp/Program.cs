using System;
using System.Threading;
using System.Threading.Tasks;
using Binance.Spot;

class Program
{
    static async Task Main(string[] args)
    {
        var websocket = new MarketDataWebSocket("btcusdt@aggTrade");

        websocket.OnMessageReceived(
            (data) =>
            {
                Console.WriteLine(data);

                return Task.CompletedTask;
            }, CancellationToken.None);

        await websocket.ConnectAsync(CancellationToken.None);
    }
}

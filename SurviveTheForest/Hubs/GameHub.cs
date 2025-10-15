
namespace SurviveTheForest.Hubs;

using Microsoft.AspNetCore.SignalR;
using SurviveTheForest.Core;

public class GameHub : Hub
{
    public async Task NewGame()
    {
        var map = new Map(10, 10);
        Console.WriteLine("Map");
        await Clients.Caller.SendAsync("GameInit", map.Tiles);
    }

    public async Task HighScore()
        => await Clients.Caller.SendAsync("ShowHighScore");
}

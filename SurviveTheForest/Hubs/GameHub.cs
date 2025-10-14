
namespace SurviveTheForest.Hubs;

using Microsoft.AspNetCore.SignalR;

public class GameHub : Hub
{
    public async Task NewGame()
        => await Clients.Caller.SendAsync("GameInit");

    public async Task HighScore()
        => await Clients.Caller.SendAsync("ShowHighScore");
}

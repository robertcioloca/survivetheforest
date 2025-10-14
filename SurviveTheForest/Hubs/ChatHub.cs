
namespace SurviveTheForest.Hubs;

using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
        => await Clients.Caller.SendAsync("ReceiveMessage", user, message);
}

using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class EncodingHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
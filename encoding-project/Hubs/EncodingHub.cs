using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class EncodingHub : Hub
    {
        public async Task SendMessage(string encode)
        {
            await Clients.All.SendAsync("ReceiveMessage", $"Message received: {encode}");
        }
    }
}
using encoding_project.Service;
using Microsoft.AspNetCore.SignalR;
using System.Threading;

namespace SignalRChat.Hubs
{
    public class EncodingHub : Hub
    {
        public async Task Encode(string stringToEncode)
        {
            string result;
            try
            {
                result = EncodingService.EncodeString(stringToEncode);
            }
            catch (Exception)
            {
                throw;
            }

            foreach(var letter in result)
            {
                var delay = RandomDelay();
                Thread.Sleep(delay);
                await Clients.All.SendAsync("ReceiveMessage", letter, delay);
            }            
        }

        private int RandomDelay()
        {
            Random r = new Random();
            return r.Next(1, 5) * 1000;
        }
    }
}
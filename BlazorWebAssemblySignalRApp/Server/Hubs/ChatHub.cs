using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendingOthers(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }
        public async Task sendingAll(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}
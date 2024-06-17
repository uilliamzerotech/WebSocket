using Microsoft.AspNetCore.SignalR;

namespace FuelmanagerWebSocketClient.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string usuario, string mensagem)
        {
            await Clients.All.SendAsync("ReceiveMessage", usuario, mensagem);
        }
    }
}
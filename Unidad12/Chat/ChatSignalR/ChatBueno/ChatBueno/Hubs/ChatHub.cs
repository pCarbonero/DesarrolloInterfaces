using Microsoft.AspNetCore.SignalR;
using Models;


namespace ChatBueno.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(clsMensajeUsuario mensaje)
        {
            await Clients.All.SendAsync("ReceiveMessage", mensaje);
        }
    }
}

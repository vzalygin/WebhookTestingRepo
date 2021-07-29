using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebApi.Contracts;

namespace WebApi.Hubs
{
    public class ClientHub : Hub
    {
        public async Task OnNotify() => 
            await Clients.All.SendAsync("Send");
    }
}
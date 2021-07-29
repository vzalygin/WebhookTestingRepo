using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Lib.Models;
using WebApi.Services;

namespace WebApi.Hubs
{
    public class ClientHub : Hub
    {
        private readonly NotifyService _notifyService;

        public ClientHub(NotifyService notifyService)
        {
            _notifyService = notifyService;
            _notifyService.Nofity += OnNotify;
        }
        
        public async Task OnNotify() => 
            await Clients.All.SendAsync("Send");
    }
}
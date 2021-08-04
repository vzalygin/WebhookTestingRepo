using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebApi.Contracts;

namespace WebApi.Hubs
{
    public class NotifyHub : Hub
    {
        public async Task OnNotifyAsync()
        {
            Console.WriteLine("Send method begins");
            await Clients.All.SendAsync("Send");   
            Console.WriteLine("Send method ends");
        }
    }
}
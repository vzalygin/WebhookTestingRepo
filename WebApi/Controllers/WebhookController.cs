using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Contracts;
using WebApi.Hubs;

namespace WebApi.Controllers
{
    public class WebhookController : ControllerBase
    {
        private readonly NotifyHub _notifyHub;

        public WebhookController(NotifyHub notifyHub)
        {
            _notifyHub = notifyHub;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("OK!");
        }

        [HttpPost]
        public async Task<ActionResult> Index([FromBody] PushNotify notify)
        {
            Console.WriteLine(notify.Repository.Name);
            await _notifyHub.OnNotifyAsync();
            return Ok();
        }
    }
}
using System;
using Microsoft.AspNetCore.Mvc;
using Lib.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    public class WebhookController : ControllerBase
    {
        private readonly NotifyService _notifyService;

        public WebhookController(NotifyService notifyService)
        {
            _notifyService = notifyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("OK!");
        }

        [HttpPost]
        public IActionResult Index([FromBody] PushNotify notify)
        {
            Console.WriteLine(notify.Repository.Name);
            _notifyService.Nofity();
            return Ok();
        }
    }
}
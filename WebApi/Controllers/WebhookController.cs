﻿using System;
using Microsoft.AspNetCore.Mvc;
using Lib.Models;

namespace WebApi.Controllers
{
    public class WebhookController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("OK!");
        }

        [HttpPost]
        public IActionResult Index([FromBody] PushNotify notify)
        {
            Console.WriteLine(notify.Repository.Name);
            return Ok();
        }
    }
}
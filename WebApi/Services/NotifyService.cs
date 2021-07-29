using System;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public class NotifyService
    {
        public Func<Task> Nofity { get; set; }
    }
}
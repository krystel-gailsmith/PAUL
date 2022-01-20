using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using PAUL.Hubs;

namespace PAUL.Controllers
{
    [ApiController]
    [Route("ROS/Communication")]
    public class BroadcastController : Controller
    {
        private readonly IHubContext<ChatHub> _hub;

        public BroadcastController(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }

        // SignalR communication
        [HttpGet]
        public async Task Get(string user, string message)
        {
            await _hub.Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

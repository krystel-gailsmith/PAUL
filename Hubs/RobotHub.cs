using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PAUL.Hubs
{
    public class RobotHub : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.SendAsync("Send", message);
        }
    }
}

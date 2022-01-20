using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using PAUL.Hubs;
using PAUL.Models;

using PAUL.Models.Command;

namespace PAUL.Controllers
{
    public class RobotController : Controller
    {
        private readonly ILogger<RobotController> _logger;


        public RobotController(ILogger<RobotController> logger)
        {
            _logger = logger;
        }

        // Classic MVC communication
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CommandStatus command)
        {
            int ID = command.ID;
            string msg = command.Description;

            // Faire quelque chose ici
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

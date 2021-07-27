using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PAUL.Models;

using PAUL.Models.Command;

namespace PAUL.Controllers
{
    public class RobotController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RobotController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int commandStatus)
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

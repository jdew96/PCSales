using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PcSales.Models;

namespace PcSales.Controllers
{
    public class SystemController : Controller
    {
        private readonly ILogger<SystemController> _logger;

        public SystemController(ILogger<SystemController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("api/[controller]/getAll")]
        public ActionResult<IEnumerable<Models.System>> GetAllSystems()
        {
            // Will use dummy data for the time being to test functionality 
            return new[]
            {
                new Models.System { Name =  "System 1", Price = 147.00 },
                new Models.System {  Name = "System 2", Price = 312.32}
            };
        }
    }
}

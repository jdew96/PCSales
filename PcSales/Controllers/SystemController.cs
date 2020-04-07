using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PcSales.Models;
using PcSales.Models.Interfaces;

namespace PcSales.Controllers
{
    public class SystemController : Controller
    {
        private readonly ILogger<SystemController> _logger;
        private readonly ISystemRepository _systemRepository;

        public SystemController(ILogger<SystemController> logger, ISystemRepository systemRepository)
        {
            _logger = logger;
            _systemRepository = systemRepository;
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
        public ActionResult<IEnumerable<Models.SystemForSale>> GetAllSystems()
        {
             return _systemRepository.GetAllSystems().ToList();
        }
    }
}

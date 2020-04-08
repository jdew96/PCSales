using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
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

        public IActionResult Update()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("api/[controller]/GetAll")]
        public ActionResult<IEnumerable<SystemForSale>> GetAllSystems()
        {
             return _systemRepository.GetAllSystems().ToList();
        }

        [Route("api/[controller]/UpdateSystem/")]
        public ActionResult<int> UpdateSystem([FromBody] SystemForSale system)
        {
            return _systemRepository.Update(system);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PcSales.Models;
using PcSales.Models.Interfaces;
using static PcSales.Models.Repositories.SystemRepository;

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

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("api/[controller]/AddSystem/")]
        public ActionResult<int> AddSystem([FromBody] SystemForSale system)
        {
            return _systemRepository.Add(system);
        }

        [Route("/api/[controller]/DeleteSystem/{id}")]
        public ActionResult<int> DeleteSystem(int id)
        {
            int delete_return = _systemRepository.Delete(id);
            return delete_return;
        }


        [HttpGet("api/[controller]/GetAll")]
        public ActionResult<IEnumerable<SystemForSale>> GetAll()
        {
             return _systemRepository.GetAll().ToList();
        }

        [HttpGet("api/[controller]/GetSystem/{id}")]
        public ActionResult<SystemForSale> GetSystem(int id)
        {
            return _systemRepository.GetSystem(id);
        }

        [Route("api/[controller]/UpdateSystem/")]
        public ActionResult<int> UpdateSystem([FromBody] SystemForSale system)
        {
            return _systemRepository.Update(system);
        }

        // Modify parts attached to system
        [Route("api/[controller]/UpdatePartsList/")]
        public ActionResult<int> UpdatePartsList([FromBody] CompositeList partsToSubmit)
        {
            return _systemRepository.UpdatePartsList(partsToSubmit);
        }


    }
}

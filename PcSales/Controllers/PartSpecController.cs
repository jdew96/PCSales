using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PcSales.Models;
using PcSales.Models.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PcSales.Controllers
{
    public class PartSpecController : Controller
    {

        private readonly IPartSpecRespository _partSpecRepository;

        public PartSpecController(IPartSpecRespository partSpecRespository)
        {
            _partSpecRepository = partSpecRespository;
        }

        public IActionResult Add()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("api/[controller]/AddCaseSpec/")]
        public ActionResult<int> AddCaseSpec([FromBody] CaseSpec spec)
        {
            return _partSpecRepository.AddCaseSpec(spec);
        }


        [HttpGet("api/[controller]/GetAll")]
        public ActionResult<IEnumerable<CaseSpec>> GetAllCaseSpecs()
        {
            return _partSpecRepository.GetAllCaseSpecs().ToList();
        }

        // Make endpoints for view and add for each part type

    }
}

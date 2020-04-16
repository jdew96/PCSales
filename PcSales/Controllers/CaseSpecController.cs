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
    public class CaseSpecController : Controller
    {

        private readonly ICaseSpecRespository _caseSpecRepository;

        public CaseSpecController(ICaseSpecRespository caseSpecRespository)
        {
            _caseSpecRepository = caseSpecRespository;
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

        public IActionResult Update()
        {
            return View();
        }


        [Route("api/[controller]/AddCaseSpec/")]
        public ActionResult<int> AddCaseSpec([FromBody] CaseSpec spec)
        {
            return _caseSpecRepository.Add(spec);
        }

        [Route("/api/[controller]/DeleteCaseSpec/{id}")]
        public ActionResult<int> DeleteCaseSpec(int partNum)
        {
            return _caseSpecRepository.Delete(partNum);
        }


        [HttpGet("api/[controller]/GetAll")]
        public ActionResult<IEnumerable<CaseSpec>> GetAll()
        {
            return _caseSpecRepository.GetAll().ToList();
        }

        [Route("api/[controller]/UpdateCaseSpec/")]
        public ActionResult<int> UpdateSystem([FromBody] CaseSpec spec)
        {
            return _caseSpecRepository.Update(spec);
        }


    }
}

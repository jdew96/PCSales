using System.Collections.Generic;
using System.Linq;
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

        public IActionResult CaseSpecIndex()
        {
            return View();
        }

        public IActionResult CpuSpecIndex()
        {
            return View();
        }

        public IActionResult GpuSpecIndex()
        {
            return View();
        }

        public IActionResult MoboSpecIndex()
        {
            return View();
        }

        public IActionResult PsuSpecIndex()
        {
            return View();
        }

        public IActionResult RamSpecIndex()
        {
            return View();
        }

        public IActionResult StorageSpecIndex()
        {
            return View();
        }

        // Get all part specs for individual system
        [Route("api/[controller]/GetSpecsForSystem/{sysId}")]
        public ActionResult<SystemPartsList> GetSpecsForSystem(int sysId)
        {
            return _partSpecRepository.GetPartsForSystem(sysId);
        }

        // Get all parts which could potentially be added to system
        [Route("api/[controller]/GetPotentialParts/{sysId}")]
        public ActionResult<PartsList> GetPotentialParts(int sysId)
        {
            return _partSpecRepository.GetPotentialParts(sysId);
        }
        

        //CaseSpec
        [HttpGet("api/[controller]/GetAllCaseSpecs")]
        public ActionResult<IEnumerable<CaseSpec>> GetAllCaseSpecs()
        {
            return _partSpecRepository.GetAllCaseSpecs().ToList();
        }


        //CpuSpec
        [HttpGet("api/[controller]/GetAllCpuSpecs")]
        public ActionResult<IEnumerable<CpuSpec>> GetAllCpuSpecs()
        {
            return _partSpecRepository.GetAllCpuSpecs().ToList();
        }

        //GpuSpec
        [HttpGet("api/[controller]/GetAllGpuSpecs")]
        public ActionResult<IEnumerable<GpuSpec>> GetAllGpuSpecs()
        {
            return _partSpecRepository.GetAllGpuSpecs().ToList();
        }

        //MoboSpec
        [HttpGet("api/[controller]/GetAllMoboSpecs")]
        public ActionResult<IEnumerable<MoboSpec>> GetAllMoboSpecs()
        {
            return _partSpecRepository.GetAllMoboSpecs().ToList();
        }

        //PsuSpec
        [HttpGet("api/[controller]/GetAllPsuSpecs")]
        public ActionResult<IEnumerable<PsuSpec>> GetAllPsuSpecs()
        {
            return _partSpecRepository.GetAllPsuSpecs().ToList();
        }

        //RamSpec
        [HttpGet("api/[controller]/GetAllRamSpecs")]
        public ActionResult<IEnumerable<RamSpec>> GetAllRamSpecs()
        {
            return _partSpecRepository.GetAllRamSpecs().ToList();
        }

        //StorageSpec
        [HttpGet("api/[controller]/GetAllStorageSpecs")]
        public ActionResult<IEnumerable<StorageSpec>> GetAllStorageSpecs()
        {
            return _partSpecRepository.GetAllStorageSpecs().ToList();
        }
     }
}

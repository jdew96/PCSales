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
        
        //CaseSpec
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


          //CpuSpec
          [Route("api/[controller]/AddCpuSpec/")]
          public ActionResult<int> AddCpuSpec([FromBody] CpuSpec spec)
          {
               return _partSpecRepository.AddCpuSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<CpuSpec>> GetAllCpuSpecs()
          {
               return _partSpecRepository.GetAllCpuSpecs().ToList();
          }

          //GpuSpec
          [Route("api/[controller]/AddCaseSpec/")]
          public ActionResult<int> AddGpuSpec([FromBody] GpuSpec spec)
          {
               return _partSpecRepository.AddGpuSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<GpuSpec>> GetAllGpuSpecs()
          {
               return _partSpecRepository.GetAllGpuSpecs().ToList();
          }

          //MoboSpec
          [Route("api/[controller]/AddMoboSpec/")]
          public ActionResult<int> AddMoboSpec([FromBody] MoboSpec spec)
          {
               return _partSpecRepository.AddMoboSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<MoboSpec>> GetAllMoboSpecs()
          {
               return _partSpecRepository.GetAllMoboSpecs().ToList();
          }

          //PsuSpec
          [Route("api/[controller]/AddPsuSpec/")]
          public ActionResult<int> AddPsuSpec([FromBody] PsuSpec spec)
          {
               return _partSpecRepository.AddPsuSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<PsuSpec>> GetAllPsuSpecs()
          {
               return _partSpecRepository.GetAllPsuSpecs().ToList();
          }

          //RamSpec
          [Route("api/[controller]/AddRamSpec/")]
          public ActionResult<int> AddRamSpec([FromBody] RamSpec spec)
          {
               return _partSpecRepository.AddRamSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<RamSpec>> GetAllRamSpecs()
          {
               return _partSpecRepository.GetAllRamSpecs().ToList();
          }

          //StorageSpec
          [Route("api/[controller]/AddStorageSpec/")]
          public ActionResult<int> AddStorageSpec([FromBody] StorageSpec spec)
          {
               return _partSpecRepository.AddStorageSpec(spec);
          }


          [HttpGet("api/[controller]/GetAll")]
          public ActionResult<IEnumerable<StorageSpec>> GetAllStorageSpecs()
          {
               return _partSpecRepository.GetAllStorageSpecs().ToList();
          }
     }
}

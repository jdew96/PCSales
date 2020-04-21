using System;
using System.Collections.Generic;
using System.Linq;
using PcSales.Models.Interfaces;

namespace PcSales.Models.Repositories
{
    public class PartSpecRepository : IPartSpecRespository
    {
        private readonly AppDbContext _context;

        public PartSpecRepository(AppDbContext context)
        {
            _context = context;
        }

        public int AddCaseSpec(CaseSpec spec)
        {
            _context.CaseSpec.Add(spec);
            return _context.SaveChanges();
        }

        // Get all parts for specific system
        public SystemPartsList GetPartsForSystem(int sysId)
        {
            List<SystemToPart> stp = _context.SystemToPart.Where(s => s.SystemId == sysId).ToList();
            SystemPartsList parts = new SystemPartsList();

            // Match up parts via system id and return full list 
            foreach(var part in stp)
            {
                switch (part.PartTypeId)
                {
                    // CPU
                    case 0:
                        parts.selectedCpu = GetCpuSpec(part.PartNum);
                        break;
                    // Mobo
                    case 1:
                        parts.selectedMobo = GetMoboSpec(part.PartNum);
                        break;
                    // RAM
                    case 2:
                        parts.selectedRam = GetRamSpec(part.PartNum);
                        break;
                    // Case
                    case 3:
                        parts.selectedCase = GetCaseSpec(part.PartNum);
                        break;
                    // GPU
                    case 4:
                        parts.selectedGpu = GetGpuSpec(part.PartNum);
                        break;
                    // PSU
                    case 5:
                        parts.selectedPsu = GetPsuSpec(part.PartNum);
                        break;
                    // Storage
                    case 6:
                        parts.selectedStorage = GetStorageSpec(part.PartNum);
                        break;
                    default:
                        break;
                }
            }

            return parts;
        }

        // Get all specs which could potentially be added to system
        public PartsList GetPotentialParts(int sysId)
        {
            SystemPartsList chosenParts = GetPartsForSystem(sysId);

            // All parts not currently chosen are options
            PartsList potentialParts = new PartsList();

            // If there are parts registered, select all others
            // If not, all parts are potential 
            potentialParts.CaseSpecs = chosenParts.selectedCase != null ?
                GetAllCaseSpecs().Where(c => c.PartNum != chosenParts.selectedCase.PartNum).ToList() : GetAllCaseSpecs();

            potentialParts.CpuSpecs = chosenParts.selectedCpu != null ?
                GetAllCpuSpecs().Where(c => c.PartNum != chosenParts.selectedCpu.PartNum).ToList() : potentialParts.CpuSpecs = GetAllCpuSpecs();

            potentialParts.GpuSpecs = chosenParts.selectedGpu != null ?
                GetAllGpuSpecs().Where(g => g.PartNum != chosenParts.selectedGpu.PartNum).ToList() : GetAllGpuSpecs();

            potentialParts.MoboSpecs = chosenParts.selectedMobo != null ?
                    GetAllMoboSpecs().Where(m => m.PartNum != chosenParts.selectedMobo.PartNum).ToList(): GetAllMoboSpecs();

            potentialParts.PsuSpecs = chosenParts.selectedPsu != null ?
                GetAllPsuSpecs().Where(p => p.PartNum != chosenParts.selectedPsu.PartNum).ToList() : GetAllPsuSpecs();

            potentialParts.RamSpecs = chosenParts.selectedRam != null ?
                GetAllRamSpecs().Where(r => r.PartNum != chosenParts.selectedRam.PartNum).ToList() : GetAllRamSpecs();

            potentialParts.StorageSpecs = chosenParts.selectedStorage != null ?
                GetAllStorageSpecs().Where(s => s.PartNum != chosenParts.selectedStorage.PartNum).ToList() : GetAllStorageSpecs();

            return potentialParts;
        }


        public List<CaseSpec> GetAllCaseSpecs()
        {
            List<CaseSpec> specs = _context.CaseSpec.ToList();
            return specs;
        }

        public CaseSpec GetCaseSpec(int partNum)
        {
            return _context.CaseSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //CpuSpec
        public List<CpuSpec> GetAllCpuSpecs()
        {
            List<CpuSpec> specs = _context.CpuSpec.ToList();
            return specs;
        }

        public CpuSpec GetCpuSpec(int partNum)
        {
            return _context.CpuSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //GpuSpec
        public List<GpuSpec> GetAllGpuSpecs()
        {
            List<GpuSpec> specs = _context.GpuSpec.ToList();
            return specs;
        }

        public GpuSpec GetGpuSpec(int partNum)
        {
            return _context.GpuSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //MoboSpec
        public List<MoboSpec> GetAllMoboSpecs()
        {
            List<MoboSpec> specs = _context.MoboSpec.ToList();
            return specs;
        }

        public MoboSpec GetMoboSpec(int partNum)
        {
            return _context.MoboSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //PsuSpec
        public List<PsuSpec> GetAllPsuSpecs()
        {
            List<PsuSpec> specs = _context.PsuSpec.ToList();
            return specs;
        }

        public PsuSpec GetPsuSpec(int partNum)
        {
            return _context.PsuSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //RamSpec
        public List<RamSpec> GetAllRamSpecs()
        {
            List<RamSpec> specs = _context.RamSpec.ToList();
            return specs;
        }

        public RamSpec GetRamSpec(int partNum)
        {
            return _context.RamSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

        //StorageSpec
        public List<StorageSpec> GetAllStorageSpecs()
        {
            List<StorageSpec> specs = _context.StorageSpec.ToList();
            return specs;
        }

        public StorageSpec GetStorageSpec(int partNum)
        {
            return _context.StorageSpec.FirstOrDefault(s => s.PartNum == partNum);
        }
    }
}
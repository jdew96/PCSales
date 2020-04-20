using System;
using System.Collections.Generic;

namespace PcSales.Models.Interfaces
{
    public interface IPartSpecRespository
    {
        // Get all parts for specific system
        SystemPartsList GetPartsForSystem(int sysId);

        // Get all parts which could potentially be added to system
        PartsList GetPotentialParts(int sysId);

        //CaseSpec
        CaseSpec GetCaseSpec(int partNum);
        List<CaseSpec> GetAllCaseSpecs();
        int AddCaseSpec(CaseSpec spec);

        //CpuSpec
        CpuSpec GetCpuSpec(int partNum);
        List<CpuSpec> GetAllCpuSpecs();
        int AddCpuSpec(CpuSpec spec);

        //GpuSpec
        GpuSpec GetGpuSpec(int partNum);
        List<GpuSpec> GetAllGpuSpecs();
        int AddGpuSpec(GpuSpec spec);

        //MoboSpec
        MoboSpec GetMoboSpec(int partNum);
        List<MoboSpec> GetAllMoboSpecs();
        int AddMoboSpec(MoboSpec spec);

        //PsuSpec
        PsuSpec GetPsuSpec(int partNum);
        List<PsuSpec> GetAllPsuSpecs();
        int AddPsuSpec(PsuSpec spec);

        //RamSpec
        RamSpec GetRamSpec(int partNum);
        List<RamSpec> GetAllRamSpecs();
        int AddRamSpec(RamSpec spec);

        //StorageSpec
        StorageSpec GetStorageSpec(int partNum);
        List<StorageSpec> GetAllStorageSpecs();
        int AddStorageSpec(StorageSpec spec);
     }
}

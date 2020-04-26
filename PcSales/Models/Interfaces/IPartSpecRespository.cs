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

        //CpuSpec
        CpuSpec GetCpuSpec(int partNum);
        List<CpuSpec> GetAllCpuSpecs();

        //GpuSpec
        GpuSpec GetGpuSpec(int partNum);
        List<GpuSpec> GetAllGpuSpecs();

        //MoboSpec
        MoboSpec GetMoboSpec(int partNum);
        List<MoboSpec> GetAllMoboSpecs();

        //PsuSpec
        PsuSpec GetPsuSpec(int partNum);
        List<PsuSpec> GetAllPsuSpecs();

        //RamSpec
        RamSpec GetRamSpec(int partNum);
        List<RamSpec> GetAllRamSpecs();

        //StorageSpec
        StorageSpec GetStorageSpec(int partNum);
        List<StorageSpec> GetAllStorageSpecs();
     }
}

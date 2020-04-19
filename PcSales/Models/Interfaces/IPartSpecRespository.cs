using System;
using System.Collections.Generic;

namespace PcSales.Models.Interfaces
{
    public interface IPartSpecRespository
    {
          //CaseSpec
          CaseSpec GetCaseSpec(int partNum);
          IEnumerable<CaseSpec> GetAllCaseSpecs();
          int AddCaseSpec(CaseSpec spec);

          //CpuSpec
          CpuSpec GetCpuSpec(int partNum);
          IEnumerable<CpuSpec> GetAllCpuSpecs();
          int AddCpuSpec(CpuSpec spec);

          //GpuSpec
          GpuSpec GetGpuSpec(int partNum);
          IEnumerable<GpuSpec> GetAllGpuSpecs();
          int AddGpuSpec(GpuSpec spec);

          //MoboSpec
          MoboSpec GetMoboSpec(int partNum);
          IEnumerable<MoboSpec> GetAllMoboSpecs();
          int AddMoboSpec(MoboSpec spec);

          //PsuSpec
          PsuSpec GetPsuSpec(int partNum);
          IEnumerable<PsuSpec> GetAllPsuSpecs();
          int AddPsuSpec(PsuSpec spec);

          //RamSpec
          RamSpec GetRamSpec(int partNum);
          IEnumerable<RamSpec> GetAllRamSpecs();
          int AddRamSpec(RamSpec spec);

          //StorageSpec
          StorageSpec GetStorageSpec(int partNum);
          IEnumerable<StorageSpec> GetAllStorageSpecs();
          int AddStorageSpec(StorageSpec spec);
     }
}

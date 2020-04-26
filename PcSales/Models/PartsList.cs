using System;
using System.Collections.Generic;

namespace PcSales.Models
{
    public class PartsList
    {
        public List<CaseSpec> CaseSpecs { get; set; }
        public List<CpuSpec> CpuSpecs { get; set; }
        public List<GpuSpec> GpuSpecs { get; set; }
        public List<MoboSpec> MoboSpecs { get; set; }
        public List<PsuSpec> PsuSpecs { get; set; }
        public List<RamSpec> RamSpecs { get; set; }
        public List<StorageSpec> StorageSpecs { get; set; }
    }
}

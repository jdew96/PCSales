using System;
namespace PcSales.Models
{
    public class SystemPartsList
    {
        public CaseSpec selectedCase { get; set; }
        public CpuSpec selectedCpu { get; set; }
        public GpuSpec selectedGpu { get; set; }
        public MoboSpec selectedMobo { get; set; }
        public PsuSpec selectedPsu { get; set; }
        public RamSpec selectedRam { get; set; }
        public StorageSpec selectedStorage { get; set; }
    }
}

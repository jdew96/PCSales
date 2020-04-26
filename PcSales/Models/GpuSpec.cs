using System;
namespace PcSales.Models
{
    public class GpuSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public int VRAM { get; set; }
        public double ClockSpeed { get; set; }
        public string ChipSet { get; set; }
        public string MemoryType { get; set; }
        public int TDP { get; set; }
        public int PartTypeId { get; set; }
    }
}

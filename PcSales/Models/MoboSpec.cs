using System;
namespace PcSales.Models
{
    public class MoboSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public string FormFactor { get; set; }
        public int SataSlots { get; set; }
        public string Socket { get; set; }
        public double MemoryMax { get; set; }
        public string MemoryType { get; set; }
        public int MemorySlots { get; set; }
        public int M2Slots { get; set; }
    }
}

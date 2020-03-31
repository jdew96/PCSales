using System;
namespace PcSales.Models
{
    public class RamSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public string MemoryType { get; set; }
        public int MemoryModules { get; set; }
        public int MemoryTotal { get; set; }
        public double ClockSpeed { get; set;  }
    }
}

using System;
namespace PcSales.Models
{
    public class CpuSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public int CoreCount { get; set; }
        public int TDP { get; set; } 
        public string Socket { get; set; }
        public double ClockSpeed { get; set; }
    }
}

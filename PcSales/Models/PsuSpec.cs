using System;
namespace PcSales.Models
{
    public class PsuSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public int Wattage { get; set; }
        public bool Modular { get; set; }
        public string EfficiencyRating { get; set; }
        public string FormFactor { get; set; }
    }
}

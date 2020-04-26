using System;
namespace PcSales.Models
{
    public class CaseSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public string FormFactor { get; set; }
        public int PartTypeId { get; set; }
    }
}

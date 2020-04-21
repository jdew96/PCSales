using System;
namespace PcSales.Models
{
    public class StorageSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public string Interface { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int PartTypeId { get; set; }
    }
}

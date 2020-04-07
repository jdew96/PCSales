using System;

namespace PcSales.Models
{
    public class SystemForSale
    { 
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public double Price { get; set; }
        public int InventoryCount { get; set;}
    }
}

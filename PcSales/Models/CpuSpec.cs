﻿using System;
namespace PcSales.Models
{
    public class CpuSpec
    {
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string PartName { get; set; }
        public int CoresCount { get; set; }
        public int TDP { get; set; } 
        public string Socket { get; set; }
        public double ClockSpeed { get; set; }
        public int PartTypeId { get; set; }
    }
}

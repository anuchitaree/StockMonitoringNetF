﻿using System.ComponentModel.DataAnnotations;

namespace StockMonitoringNetF.Models
{
    public partial class Pattern
    {
        [Key]
        public string  SectionCode { get; set; }
        public int TotalLength { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public string Example { get; set; }
    }
}

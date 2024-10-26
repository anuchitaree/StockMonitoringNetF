using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class ChartMonitor
    {
        public string PartNumber { get; set; }
        public int Qty { get; set; }
        public int UpperLimit { get; set; }
        public int LowerLimit { get; set; }
        public int LowerLoLimit { get; set; }
    }
}

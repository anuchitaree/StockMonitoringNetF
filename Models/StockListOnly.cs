using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class StockListOnly
    {
        public string PartNumber { get; set; }
        public int Balance { get; set; }
        public int PiecePerKanban { get; set; }
        public int HHLimit { get; set; }
        public int HLimit { get; set; }
        public int LLimit { get; set; }
        public int LLLimt { get; set; }
        public bool ActivePn { get; set; }
    }
}

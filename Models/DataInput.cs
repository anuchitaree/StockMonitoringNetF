using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class DataInput
    {
        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public string PartNumber { get; set; }
        public int PiecePerKanban { get; set; }
      
    }
}

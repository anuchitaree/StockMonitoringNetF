using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class StockDataInputRequert
    {

        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public string PartNumber { get; set; }
        public int PiecePerKanban { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}

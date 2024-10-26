using System;

namespace StockMonitoringNetF.Models
{
    public class StockListLogRequest
    {

        public int RowNumber { get; set; }
        public string SectionCode { get; set; }
        public DateTime Registdatetime { get; set; }
        public string PartNumber { get; set; }
        public int Balance { get; set; }

    }
}

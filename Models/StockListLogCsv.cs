
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class StockListLogCsv
    {
       
        public string SectionCode { get; set; }
        public DateTime Registdatetime { get; set; }
        public string PartNumber { get; set; }
        public int Balance { get; set; }


    }
}

namespace StockMonitoringNetF.Models
{
    public class StockMonitorRequest
    {
        public string SectionCode { get; set; }
        public string PartNumber { get; set; }
        public int Qty { get; set; }
    }


    public class PartQty
    {
        public string PartNumber { get; set; }
        public int Qty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class PortSetting
    {
        public int Channel { get; set; }
        public string  Com { get; set; }
        public string  BaudRate { get; set; }
        public string  Parity { get; set; }

        public string Length { get; set; }
        public string StopBit { get; set; }
        public string Direction { get; set; }
    }
}

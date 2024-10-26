using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace StockMonitoringNetF.Modules
{
    public static class SerialPortSetting
    {

        public static void Close(SerialPort serialPort)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();
                    serialPort.Close();
                    serialPort = null;
                }
            }
        }
    }
}

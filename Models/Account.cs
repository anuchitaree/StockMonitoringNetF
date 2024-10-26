using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockMonitoringNetF.Models
{
    public class Account
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Events
{
    public class StockTradedEventArgs : EventArgs
    {
        public string StockBrokerName { get; set; }
        public string StockName { get; set; }

        public DateTime TimeTraded { get; set; }
    }
}

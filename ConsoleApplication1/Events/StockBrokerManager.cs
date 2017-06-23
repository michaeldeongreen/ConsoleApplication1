using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Events
{
    public class StockBrokerManager : IStockBrokerManager
    {
        private string _name;
        public StockBrokerManager(string name)
        {
            _name = name;
        }

        public void StockTradedHandler(object sender, StockTradedEventArgs e)
        {
            Console.WriteLine(string.Format("{0} traded stock {1} at {2}.",e.StockBrokerName,e.StockName,e.TimeTraded.ToString("MM/dd/yyyy")));
        }
    }
}

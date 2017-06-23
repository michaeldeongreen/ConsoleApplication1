using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Events
{
    public class StockBroker : IStockBroker
    {
        public event EventHandler<StockTradedEventArgs> StockTraded;
        private string _name;

        public StockBroker(string name)
        {
            _name = name;
        }

        public void TradeStock(string stockName)
        {
            StockTradedEventArgs eventArgs = new StockTradedEventArgs() { StockBrokerName = _name, StockName = stockName, TimeTraded = DateTime.Now };
            this.OnStockTraded(eventArgs);
        }

        protected virtual void OnStockTraded(StockTradedEventArgs e)
        {
            EventHandler<StockTradedEventArgs> handler = StockTraded;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Events
{
    public interface IStockBroker
    {
        event EventHandler<StockTradedEventArgs> StockTraded;

        void TradeStock(string stockName);
    }
}

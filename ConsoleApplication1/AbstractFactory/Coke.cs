using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    public class Coke : IProduct
    {
        public string GetName()
        {
            return "Coke";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    public class Pepsi : IProduct
    {
        public string GetName()
        {
            return "Pepsi";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    public class PepsiProductFactory : AbstractProductFactory
    {
        public override IProduct NewSoda()
        {
            return new Pepsi();
        }
    }
}

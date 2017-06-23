using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    public class SodaFactory : AbstractSodaFactory
    {
        public override AbstractProductFactory CreateNewCokeProductFactory()
        {
            return new CokeProductFactory();
        }

        public override AbstractProductFactory CreateNewPepsiProductFactory()
        {
            return new PepsiProductFactory();
        }

        public override AbstractProductFactory CreateNewSpriteProductFactory()
        {
            return new SpriteProductFactory();
        }
    }
}

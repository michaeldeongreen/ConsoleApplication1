using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    public abstract class AbstractSodaFactory
    {
        public abstract AbstractProductFactory CreateNewCokeProductFactory();

        public abstract AbstractProductFactory CreateNewPepsiProductFactory();

        public abstract AbstractProductFactory CreateNewSpriteProductFactory();
    }
}

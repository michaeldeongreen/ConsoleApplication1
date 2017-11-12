using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructureMapAddAllTypesOf
{
    public class ThisService : IService
    {
        public void Print()
        {
            Console.WriteLine("I am a ThisService");
        }
    }
}

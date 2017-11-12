using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructureMapAddAllTypesOf
{
    public class DoSomethingService : IDoSomethingService
    {
        private readonly IEnumerable<IService> _services;
        //injecting a list of all classes that inherit from IService
        //remember, in StructureMapAddAllTypesOfIoC.Init, we used AddAllTypesOf, which is saying, anytime we ask for IService, gives a list of all classes that inherit from IService
        public DoSomethingService(IEnumerable<IService> services)
        {
            _services = services; 
        }
        public void Do()
        {
            foreach (var service in _services)
            {
                service.Print(); //looping through and printing each classes Print method, think about how you could do this for CalculatedVariables
            }
        }
    }
}

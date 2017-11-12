using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Graph;

namespace ConsoleApplication1.StructureMapAddAllTypesOf
{
    public static class StructureMapAddAllTypesOfIoC
    {
        public static IContainer MyContainer { get { return _myContainer;} }
        private static IContainer _myContainer;
        public static void Init()
        {
           IContainer container = new Container(c => {
                c.Scan(x => {
                    x.TheCallingAssembly(); //scan the assemblies so StructureMap can register any DLLs it needs
                    x.WithDefaultConventions(); //this means that if it sees a IService, it will associated it with Service or ICreditReportParserService, it will look for CreditReportParserService
                    x.AddAllTypesOf<IService>(); //we want to auto register all classes that inherit from IService interface
                });
           });

           _myContainer = container.GetNestedContainer(); //creating a nested containter which means when you destroy the _myContainer, all objects inside are destroyed
        }
    }
}

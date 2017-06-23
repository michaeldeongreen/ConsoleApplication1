using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Graph;

namespace ConsoleApplication1.StructureMapConstructorInjection
{
    public static class StructureMapConstructorInjectionIoC
    {
        public static IContainer MyContainer { get { return _myContainer;} }
        private static IContainer _myContainer;
        public static void Init()
        {
           IContainer container = new Container(c => {
                c.Scan(x => {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });

               c.For<IConstructor>().Use(new Constructor("www.google.com"));
            });

           _myContainer = container;
        }
    }
}

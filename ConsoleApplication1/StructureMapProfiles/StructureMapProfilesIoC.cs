using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Graph;

namespace ConsoleApplication1.StructureMapProfiles
{
    public static class StructureMapProfilesIoC
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

               c.For<IBreadCrumbPath>().Use<HisBreadCrumbPath>();

                c.Profile("profile1", p => {
                p.For<IBreadCrumbPath>().Use<HisBreadCrumbPath>();
                });

                c.Profile("profile2", p =>
                {
                p.For<IBreadCrumbPath>().Use<HerBreadCrumbPath>();
                });
            });

           _myContainer = container;
        }
    }
}

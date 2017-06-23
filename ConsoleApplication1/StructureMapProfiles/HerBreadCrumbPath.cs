using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructureMapProfiles
{
    public class HerBreadCrumbPath : IBreadCrumbPath
    {
        private Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get
            {
                return _id;
            }
        }

        public string IAmA()
        {
            return "Her";
        }
    }
}

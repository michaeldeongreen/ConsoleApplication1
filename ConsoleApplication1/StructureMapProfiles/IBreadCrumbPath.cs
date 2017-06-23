using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructureMapProfiles
{
    public interface IBreadCrumbPath
    {
        Guid Id { get; }

        string IAmA();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructureMapConstructorInjection
{
    public class Constructor : IConstructor
    {
        private string _path;
        private string _separator;

        public Constructor(string path, string separator = "/")
        {
            _path = path;
            _separator = separator;
        }
        public string GetIdentifier()
        {
            return string.Format("{0}{1}",_path,_separator);
        }
    }
}

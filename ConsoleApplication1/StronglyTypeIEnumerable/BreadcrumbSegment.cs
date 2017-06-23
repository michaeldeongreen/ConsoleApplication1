using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StronglyTypeIEnumerable
{
    public class BreadcrumbSegment
    {
        private string _entity = string.Empty;
        private string _key = string.Empty;

        public string Entity { get { return _entity;}}
        public string Key { get { return _key; } }
        public BreadcrumbSegment(string entity, string key)
        {
            _entity = entity;
            _key = key;
        }
    }
}

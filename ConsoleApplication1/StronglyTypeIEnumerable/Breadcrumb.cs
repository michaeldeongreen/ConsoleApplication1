using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StronglyTypeIEnumerable
{
    public class Breadcrumb : IEnumerable<BreadcrumbSegment>
    {
        List<BreadcrumbSegment> _segments = new List<BreadcrumbSegment>();

        public Breadcrumb(string filter)
        {
            string[] entityKeyPair = filter.Split('|');
            _segments.Add(new BreadcrumbSegment(entityKeyPair[0], entityKeyPair[1]));
        }
        public IEnumerator<BreadcrumbSegment> GetEnumerator()
        {
            return _segments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

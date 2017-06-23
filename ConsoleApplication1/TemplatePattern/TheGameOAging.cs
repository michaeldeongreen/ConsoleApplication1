using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplatePattern
{
    public class TheGameOAging : TemplatePatternBase
    {
        protected override string Name
        {
            get
            {
                return "The Game of Aging";
            }
        }

        protected override string StepOne()
        {
            return "Crawl on Four Legs";
        }

        protected override string StepThree()
        {
            return "Crawl on Three Legs";
        }

        protected override string StepTwo()
        {
            return "Crawl on Two Legs";
        }
    }
}

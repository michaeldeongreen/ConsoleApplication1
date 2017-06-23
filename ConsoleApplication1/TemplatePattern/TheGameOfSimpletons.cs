using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplatePattern
{
    public class TheGameOfSimpletons : TemplatePatternBase
    {
        protected override string Name
        {
            get
            {
                return "The Game of Simpletons";
            }
        }

        protected override string StepOne()
        {
            return "Eat";
        }

        protected override string StepThree()
        {
            return "Crap";
        }

        protected override string StepTwo()
        {
            return "Sleep";
        }
    }
}

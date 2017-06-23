using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TemplatePattern
{
    public abstract class TemplatePatternBase
    {
        protected abstract string Name { get; }
        internal string TemplateMethod()
        {
            return string.Format("{0} is Step 1: {1}.  Step 2: {2}.  Step 3: {3}", Name, StepOne(), StepTwo(), StepThree());
        }
        protected abstract string StepOne();
        protected abstract string StepTwo();
        protected abstract string StepThree();
    }
}

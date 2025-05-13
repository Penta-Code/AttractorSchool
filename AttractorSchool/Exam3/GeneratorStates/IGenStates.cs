using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.GeneratorStates
{
    internal interface IGenStates
    {
        public void Gold(Generator gen);
        public void Silver(Generator gen);
        public void Bronze(Generator gen);
    }
}
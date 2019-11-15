using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBuilder
{
    public class ConcreteBuilder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU2");
        }

        public override void BuildPartMainboard()
        {
            computer.Add("Mainboard");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}

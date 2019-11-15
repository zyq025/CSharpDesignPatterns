using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBuilder
{
    /// <summary>
    /// 具体的组装者，既模式中的建造者
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU1");
        }

        public override void BuildPartMainboard()
        {
            computer.Add("Mainboard1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}

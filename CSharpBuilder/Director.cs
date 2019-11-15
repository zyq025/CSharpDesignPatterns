using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBuilder
{
    /// <summary>
    /// 老板找到组装工人进行电脑组装，这里的老板就是建造者模式中的指挥者
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainboard();
        }
    }
}

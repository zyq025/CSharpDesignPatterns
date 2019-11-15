using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBuilder
{
    public abstract class Builder
    {
        public abstract void BuildPartCPU();
        public abstract void BuildPartMainboard();

        //其他一系列，风扇、电源等等

        /// <summary>
        /// 获得组装好的电脑 
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}

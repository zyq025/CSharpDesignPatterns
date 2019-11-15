using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAbstractFactory
{
    /// <summary>
    /// 抽象类提供不同地方产品的生产接口
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }
}

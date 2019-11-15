using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAbstractFactory
{
    /// <summary>
    /// 南昌绝味工厂
    /// </summary>
    public class NanChangFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new NanChangYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new NanChangYaJia();
        }
    }
}

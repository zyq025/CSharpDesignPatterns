using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrototype
{
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        /// <summary>
        /// 浅拷贝，根据需求可以进行选择深拷贝，这里只是举例
        /// </summary>
        /// <returns></returns>
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }
}

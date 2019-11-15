using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFlyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        /// <summary>
        /// 内部状态
        /// </summary>
        private string instrinsic_state;

        public ConcreteFlyweight(string instrinsic_state)
        {
            this.instrinsic_state = instrinsic_state;
        }

        /// <summary>
        /// 享元类的实例方法
        /// </summary>
        /// <param name="extrinsic_state">外部方法</param>
        public override void Operation(int extrinsic_state)
        {
            Console.WriteLine($"具体实现类：intrinsic_state {instrinsic_state},extrinsic_state {extrinsic_state}");
        }
    }
}

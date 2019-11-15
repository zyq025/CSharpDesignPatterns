using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProxy
{
    /// <summary>
    /// 真实主题角色
    /// </summary>
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买一个IPhone和一台苹果电脑");
        }
    }
}

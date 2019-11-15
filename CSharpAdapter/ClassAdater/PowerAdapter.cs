using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdapter.ClassAdater
{
    /// <summary>
    /// 适配器类，接口继承放在最后
    /// 适配器类提供三个孔插头的行为，但本质是调用两个孔插头的方法
    /// </summary>
    public class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            Console.WriteLine("我是三孔适配器");
            this.SpecificRequest();
        }
    }
}

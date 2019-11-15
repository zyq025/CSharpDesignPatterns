using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdapter.ObjectAdater
{
    /// <summary>
    /// 三个孔的插头，也就是适配器模式中的目标角色
    /// </summary>
    public class ThreeHole
    {
        /// <summary>
        /// 客户需要的方法
        /// </summary>
        public virtual void Request()
        {
            //实现一些基本功能
            Console.WriteLine("三个孔的插头");
        }
    }
}

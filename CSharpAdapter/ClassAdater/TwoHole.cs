using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdapter.ClassAdater
{
    /// <summary>
    /// 两个孔的插头，原角色---需要适配的类
    /// </summary>
    public abstract class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}

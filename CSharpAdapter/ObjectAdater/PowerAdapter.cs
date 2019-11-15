using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdapter.ObjectAdater
{
    /// <summary>
    /// 适配器类，引用了TwoHole对象
    /// </summary>
    public class PowerAdapter : ThreeHole
    {
        //引用两个孔插头的实例，从而将客户端与TwoHole联系起来
        public TwoHole twoHole = new TwoHole();
        public override void Request()
        {
            base.Request();
            twoHole.SpecificRequest();
        }
    }
}

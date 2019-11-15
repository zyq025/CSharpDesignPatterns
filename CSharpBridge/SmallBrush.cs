using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridge
{
    public class SmallBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine($"使用细笔和颜色为{this.c.color}进行画画");
        }
    }
}

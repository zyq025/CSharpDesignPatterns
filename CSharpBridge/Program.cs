using System;

/// <summary>
/// 桥接模式：将抽象部分与实现部分脱耦，使他们可以独立变化
/// 举例：比如用蜡笔和毛笔画画，需要粗中细三种笔，红绿蓝等12种颜色
/// 对于蜡笔来说，需要粗中细不同颜色的的笔，则需要3*12=36支笔，因为笔和颜色没有分开，导致要从粗度、颜色两个维度改变
/// 对于毛笔来说，需要粗中细三支笔，红绿蓝12种颜色即可，因为两者分开
/// </summary>
namespace CSharpBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush b = new BigBrush();
            b.SetColor(new Red());
            b.Paint();

            b.SetColor(new Green());
            b.Paint();

            b.SetColor(new Blue());
            b.Paint();

            Console.WriteLine("=================使用细笔进行画画================");
            b = new SmallBrush();
            b.SetColor(new Red());
            b.Paint();

            b.SetColor(new Green());
            b.Paint();

            b.SetColor(new Blue());
            b.Paint();
        }
    }
}

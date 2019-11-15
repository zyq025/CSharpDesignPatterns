using System;

namespace CSharpComposite
{
    /// <summary>
    /// 组合模式：将对象组合成树形结构以表示"部分-整体"的层次结构。Composite模式使得用户对单个对象和组合对象的使用具有一致性
    /// 关键：简单对象和复合对象必须实现相同的接口。这就是组合模式能够将组合对象和简单对象进行一致处理的原因。
    /// 组合模式分两种：
    ///     透明组合模式：就是简单类型和复杂类型拥有相同的接口，简单类型中不需要的在接口中抛出异常即可，如果错用了，运行时发现错误
    ///     安全组合模式：就是简单类型不拥有复杂类型的接口，如果错用了，这样编译时就能发现错误
    /// 举例： 以画图为例，点、直线、线段、圆等这些都为简单对象，将其中几个简单对象组合就成组合对象 
    ///     例子中以透明组合模式为例，如果要改安全组合模式，可以修改抽象类，去简单类型不需要的接口， 复杂类型需要的接口在复杂类型中实现
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ComplexGraphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics.Add(new Line("线段"));
            ComplexGraphics complexCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
            complexCG.Add(new Circle("圆"));
            complexCG.Add(new Line("线段B"));
            complexGraphics.Add(complexCG);
            Line l = new Line("线段C");
            complexGraphics.Add(l);

            //显示复杂图形的画法
            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("=======================");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("========================");

            //移除一个组件在显示画法
            complexGraphics.Remove(l);
            Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
            Console.WriteLine("=======================");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("========================");

        }
    }
}

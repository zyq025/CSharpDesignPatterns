using System;

namespace CSharpTemplateMethod
{
    /// <summary>
    /// 模板方法设计模式：定义一个操作中的算的骨架，而将一些步骤延迟到子类中，是的子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
    /// 模板方法使用比较普遍，也比较重要
    /// 举例：炒蔬菜， 常规炒蔬菜的过程都大致差不多，如果每一种蔬菜都专门定义一个类实现，那就导致许多重复的代码
    /// </summary>
    class Program
    {
        /// <summary>
        /// 这里充当客户端调用  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Vegetable vegetable = new Spinach();
            vegetable.CookVegetable();

            Console.WriteLine("=================================");

            Vegetable vegetable1 = new ChineseCabbage();
            vegetable1.CookVegetable();
        }
    }
}

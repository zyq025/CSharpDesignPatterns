using System;

namespace CSharpAbstractFactory
{
    /// <summary>
    /// 本例采用绝味鸭脖来举例，每个地方的辣味不一样，则每个工厂要生产符合每个地方口味的产品， 以南昌和上海两个地方举例
    /// 缺点： 对新增产品不是开放--封闭原则， 因为抽象工厂中就已经确定好有哪些产品了，如果要新加，就得影响到对应的子类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //南昌工厂制作对应的鸭架和鸭脖
            AbstractFactory nanChangFactory = new NanChangFactory();
            YaBo  nanchangYabo = nanChangFactory.CreateYaBo();
            nanchangYabo.Print();
            YaJia nanchangYaJia = nanChangFactory.CreateYaJia();
            nanchangYaJia.Print();

            Console.WriteLine("=============================================");

            AbstractFactory shangHaiFactory = new ShangHaiFactory();
            YaBo shanghaiYabo = shangHaiFactory.CreateYaBo();
            shanghaiYabo.Print();
            YaJia shanghaiYaJia = shangHaiFactory.CreateYaJia();
            shanghaiYaJia.Print();
        }
    }
}

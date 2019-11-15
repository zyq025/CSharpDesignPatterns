using System;

namespace CSharpDecorator
{
    /// <summary>
    /// 装饰模式：动态地给一个对象添加一些额外的职责，同时也避免了因为扩展功能造成子类的暴增。就增加功能来说，Decorator模式相比生成子类更灵活
    /// 举例：编写一个坦克游戏，游戏中有不同类型的坦克，坦克最初功能只有run和shot,后来想增加红外线功能、水陆两栖功能、卫星定位功能
    /// 对于不同类型的坦克都有可能拥有新增的一个或多个功能，如果用继承方式实现，就要对新增功能进行不同组合的继承，这样就导致子类暴增
    /// 使用装饰模式，在原有基础上加功能就行，无需再重新生成对应的子类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new T50();

            DecoratorA tankA = new DecoratorA(tank);
            DecoratorB tankB = new DecoratorB(tankA);
            DecoratorC tankC = new DecoratorC(tankB);

            tankB.Shot();
            tankB.Run();

            Console.WriteLine("=============================");

            tankC.Shot();
            tankC.Run();

        }
    }
}

using System;

namespace CSharpFactoryMethod
{
    /// <summary>
    /// 为了解决简单工厂扩展问题，每一次扩展都要在原来代码基础上修改或增加；
    /// 工厂方法设计模式弊端： 一个工厂只创建一种产品，这样在现实生活中不太实用，因为现在都是多元化工厂，这里只是举个例
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Factory Mehtod No:");
            Console.WriteLine("================================");
            Console.WriteLine("no       factory method");
            Console.WriteLine("1        HongQiCarFactory");
            Console.WriteLine("2        BMWCarFactory");
            Console.WriteLine("================================");

            while(true)
            {
                int no = Int32.Parse(Console.ReadLine().ToString());

                //这里获取编号之后可以用反射方式创建对应的工厂类
                CarFactory carFactory = null;
                switch (no)
                {
                    case 1:
                        carFactory = new HongQiCarFactory();
                        break;
                    case 2:
                        carFactory = new BMWCarFactory();
                        break;
                    default:
                        return;
                }

                Car c = carFactory.MakeCar();

                c.StartUp();
                c.Run();
                c.Stop();
            }
            
        }
    }
}

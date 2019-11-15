using System;

namespace CSharpPrototype
{
    /// <summary>
    /// 原型模型： 创建一个类的实例过程是比较昂贵或复杂的，直接用new去创建的话，会增加创建类的复杂度和消耗更多的内存空间；
    /// 所以当我们需要多个相同的实例时，没必要用new创建出相同的实例对象，可以通过对原来对象的拷贝完成创建；
    /// 举例：孙悟空分身，或者是细胞分裂
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //悟空原型
            MonkeyKingPrototype monkeyKingPrototype = new ConcretePrototype("MonkeyKing");

            //变一个
            MonkeyKingPrototype cloneMokeyKine = monkeyKingPrototype.Clone() as ConcretePrototype;
            Console.WriteLine($"Clone ID1\t{cloneMokeyKine.Id}");


            //变一个
            MonkeyKingPrototype cloneMokeyKine2 = monkeyKingPrototype.Clone() as ConcretePrototype;
            Console.WriteLine($"Clone ID2\t{cloneMokeyKine2.Id}");
            

            //Console.WriteLine(cloneMokeyKine == cloneMokeyKine2);
        }
    }
}

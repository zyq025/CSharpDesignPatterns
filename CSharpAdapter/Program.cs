using CSharpAdapter.ClassAdater;
using System;

namespace CSharpAdapter
{
    /// <summary>
    /// 适配器设计模式：将一个类的接口转换成客户希望的另外一个接口，使得原本由于接口不兼容而不能一起工作的那些类可以一起工作；
    /// 分为两种适配器：
    ///     类适配器：通过集成目标接口和原有类进行实现
    ///     对象适配器：通过集成目标类或接口，再利用原有类对象进行实现
    /// 举例：以电器插头为例，如插座只有三个孔的口，电器需要两个孔的，所以就想把电器两个孔的转为三个孔，满足插座要求使用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //类适配器Test
            IThreeHole threeHole = new PowerAdapter();
            threeHole.Request();

            Console.WriteLine("========================以下是对象适配器========================");

            //对象适配器Test
            ObjectAdater.ThreeHole threeHole1 = new ObjectAdater.PowerAdapter();
            threeHole1.Request();
        }
    }
}

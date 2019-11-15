using System;

namespace CSharpFlyweight
{
    /// <summary>
    /// 享元模式：运用共享技术有效地支持大量细粒度的对象；
    /// 有两个状态：
    ///     内部状态：一般指不可变的，可共享的
    ///     外部状态：一般指可变，不可以共享的状态
    /// 此模式在实际应用比较少
    /// 举例：文本编辑器，一个文本编辑器中会出现很多字面，例子中会包字面做成一个享元对象。 享元对象的内部状态就是这个字面
    ///  而字母在文本中的位置和字体风格等其他信息就是它的外部状态。
    /// </summary>
    class Program
    {
        /// <summary>
        /// 这里充当客户端使用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //定义一个外部状态
            int external_state = 10;
            FlyWeightFactory flyWeightFactory = new FlyWeightFactory();

            //判断是否已经创建了字母A，如果已经创建就直接使用创建的对象A
            Flyweight fa = flyWeightFactory.GetFlyweight("A");
            if(fa!=null)
            {
                fa.Operation(--external_state);
            }

            //判断是否已经创建了字母B，如果已经创建就直接使用创建的对象B
            Flyweight fb = flyWeightFactory.GetFlyweight("B");
            if (fb != null)
            {
                fb.Operation(--external_state);
            }

            //判断是否已经创建了字母C，如果已经创建就直接使用创建的对象C
            Flyweight fc = flyWeightFactory.GetFlyweight("C");
            if (fc != null)
            {
                fc.Operation(--external_state);
            }

            //判断是否已经创建了字母D，如果已经创建就直接使用创建的对象D
            Flyweight fd = flyWeightFactory.GetFlyweight("D");
            if (fd != null)
            {
                fd.Operation(--external_state);
            }
            else
            {
                Console.WriteLine("驻留池中不存在字符串D");
                ConcreteFlyweight d = new ConcreteFlyweight("D");
                flyWeightFactory.flyweights.Add("D", d);
            }
        }
    }
}

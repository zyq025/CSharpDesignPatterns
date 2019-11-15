using System;

namespace CSharpBuilder
{
    /// <summary>
    /// 建造者模式： 主要是用于创建一些复杂对象；
    /// 举例，以采购人员找电脑城老板采购电脑为例  ，因为电脑需要CPU,主板，风扇等等，然后进行安装
    /// 牵涉人员：采购员-》电脑城老板-》安装人员(建造者)  ===》组装出电脑
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //采购员找到老板，要买两台电脑
            //找到老板(指挥者)和组装人员(建造者)
            Director director = new Director();
            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            //老板让第一个组装人员开始装
            director.Construct(builder1);

            //组装完，组装人员搬来组装好的电脑
            Computer computer = builder1.GetComputer();
            computer.Show();

            Console.WriteLine("============================");

            //老板让第二个组装人员开始装
            director.Construct(builder2);

            //组装完，组装人员搬来组装好的电脑
            Computer computer2 = builder2.GetComputer();
            computer2.Show();
        }
    }
}

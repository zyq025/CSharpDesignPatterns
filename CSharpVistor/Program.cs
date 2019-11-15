using System;

namespace CSharpVistor
{
    /// <summary>
    /// 访问者模式: 表示一个作用于某对象结构中的元素的操作。使得可以在不改变各元素的类的前提下定义作用于这些元素的新操作
    /// 数据结构的每一个节点都可以接受一个访问者的调用，此节点向访问者对象传入节点对象，而访问者对象则反过来执行节点对象的操作。这样的过程叫做“双重分派”。节点调用访问者，将它自己传入，访问者则将某算法针对此节点执行。
    /// 举例：遍历列表中元素，然后将每个元素对象的信息打印出来;
    /// 如果不采用访问模式的话，很容易实现，在每个类中写一个Print函数打印即可，但是如果打印内容改变时，每个类中的Print函数都要改变
    /// 如果采用访问模式的话，如果打印内容改变，就实现一个对应的访问者就行了，不用每个子类都修改
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure objectStructure = new ObjectStructure();
            foreach(Element element in objectStructure.Elements)
            {
                //每个元素接收访问者访问，如果有改变，就修改对应的Vistor类即可
                element.Accept(new ConcreteVistor());
            }
        }
    }
}

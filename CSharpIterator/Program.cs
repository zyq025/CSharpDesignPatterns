using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIterator
{
    /// <summary>
    /// 迭代器模式：提供一种方法顺序访问一个聚合对象中各个元素，而又不需要暴露该对象的内部表示；
    /// 即在不暴露内部结构的同时，可以让外部客户代买透明地访问其中包含的元素；
    /// 迭代角色：迭代器角色负责定义访问和遍历元素的接口
    /// 具体迭代器角色：具体迭代器角色实现了迭代器接口，并需要记录遍历中的当前位置
    /// 聚合角色：负责定义获得迭代器角色的接口
    /// 具体聚合角色：实现聚合角色接口
    /// 注意：在遍历迭代器过程中同时更改迭代器所在的集合结构会导致出现异常。所以使用foreach语句只能在对集合进行遍历，不能在遍历的同时更改集合中的元素
    /// 举例：集合遍历
    /// </summary>
    class Program
    {
        /// <summary>
        /// 客户端调用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IIterator iterator;
            IList list = new ConcreteList();
            iterator = list.GetIterator();
            while(iterator.MoveNext())
            {
                int i = (int)iterator.CurrentItem();
                Console.WriteLine(i);
                iterator.Next();
            }

        }
    }
}

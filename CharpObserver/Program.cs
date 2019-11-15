using System;

namespace CharpObserver
{
    /// <summary>
    /// 观察者模式：定义对象间的一种以对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新
    /// 抽象主题角色(Subject)：抽象主题吧所有观察者对象的引用保存在一个列表中，并提供增加和删除观察者对象的操作，抽象主题角色又叫做抽象被观察者角色，一般由抽象类或接口实现。
    /// 抽象观察者角色(Observer)：为所有具体观察者定义一个接口，在得到主题通知时更新自己，一般有抽象类或接口实现
    /// 具体主题角色(ConcreteSubject)： 实现抽象主题接口，具体主题角色又叫具体被观察者角色
    /// 具体观察者角色(ContreteObserver)：实现抽象观察者角色所要求的接口，以便使自身状态和主题状态相协调
    /// 
    /// 举例：腾讯订阅号，有多个订阅者，订阅号如果有改变就通知所有订阅者
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TenXun tenXun = new TenXunGame("TenXun Game", "Have a new game publicshed.........");
            tenXun.AddObserver(new Subscriber("Learning Hard"));
            tenXun.AddObserver(new Subscriber("Tom"));

            tenXun.Update();

            Console.WriteLine("===========使用委托实现============");

            DelegateEventExample.TenXun tenXun1 = new DelegateEventExample.TenXunGame("TenXun Game", "Have a new game published ....");
            DelegateEventExample.Subscriber lh = new DelegateEventExample.Subscriber("Learning Hard");
            DelegateEventExample.Subscriber tom = new DelegateEventExample.Subscriber("Tom");

            tenXun1.AddObserver(lh.ReceiveAndPrint);
            tenXun1.AddObserver(tom.ReceiveAndPrint);

            tenXun1.Update();

        }
    }
}

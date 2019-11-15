using System;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 责任链模式: 某个请求需要多个对象进行处理，从而避免请求的发送者和接收者之间的耦合关系。将这些对象连城一条链子，并沿着这条链子传递该请求，直到有对象处理它为止
    /// 抽象处理者角色(Handler): 定义出一个处理请求的接口。这个接口通常由接口或抽象类实现。
    /// 具体处理者角色(ConcreteHandler): 具体处理接受到请求后，可以选择将该请求处理掉，或者将请求传给下一个处理者。因此，每个具体处理者需要保存下一个处理者的引用，以便把请求传递下去；
    /// 举例：公司采购审批， 一万以内，经理级别批准即可，大于1万小于2.5万还需要副总进行审批，在2.5~10万之间需要总经理审批，超过10万需要开会讨论
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseRequest requestTelPhone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestVS = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manager = new Manager("LearningHard");
            Approver vicePresident = new VicePresident("Tony");
            Approver president = new President("BossTom");

            //设置责任链
            manager.NextProver = vicePresident;
            vicePresident.NextProver = president;

            //处理请求
            manager.ProcessRequest(requestTelPhone);
            Console.WriteLine("========================");
            manager.ProcessRequest(requestVS);
            Console.WriteLine("========================");
            manager.ProcessRequest(requestComputers);
        }
    }
}

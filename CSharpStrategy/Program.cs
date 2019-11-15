using System;

namespace CSharpStrategy
{
    /// <summary>
    /// 策略模式: 定义一系统的算法，把他们一个个封装起来，并且使他们可相互替换。本模式使得算法可独立于它的客户而变化
    /// 环境角色(Context): 持有一个Strategy类的引用
    /// 抽象策略角色(Strategy): 这是一个抽象角色，通常由一个接口或抽象类来实现。此角色给出所有具体策略类所需实现的接口。
    /// 具体策略角色(ConcreteStrategy): 包装了相关算法或行为
    /// 举例：所得税计算策略， 个人所得税、企业所得税、外商企业所得税等都有不同的算法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //个人所得税方式
            InterestOperation operation = new InterestOperation(new PersonalTaxStrategy());
            Console.WriteLine($"个人支付的税为：{operation.GetTax(5000.00)}");

            //企业所得税方式
            InterestOperation operation1 = new InterestOperation(new EnterpriseTaxStrategy());
            Console.WriteLine($"企业支付的税为：{operation.GetTax(5000.00)}");
        }
    }
}

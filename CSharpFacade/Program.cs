using System;

namespace CSharpFacade
{
    /// <summary>
    /// 外观模式：为子系统中的一组接口提供一个一致的界面，Facade模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
    /// 注意区分Facade模式、Adapter模式、Bridge模式与Decorator模式。
    /// Facade模式注重简化接口，
    /// Adapter模式注重转换接口，
    /// Bridge模式注重分离接口（抽象）与其实现，
    /// Decorator模式注重稳定接口的前提下为对象扩展功能。
    /// 举例：做一个抵押系统，当客户来了，需要做以下确认，银行子系统查询是否有足够的存款，信用子系统查询是否信用良好，到贷款子系统中查询是否有贷款劣迹
    /// 只有各个子系统符合预期，才能进行抵押
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //传统方式，与各个子系统直接耦合
            Pledge();

            Console.WriteLine();
            Console.WriteLine("============================================");
            //使用外观模式，与各个子系统解耦，其实分层结构也是使用了外观模式的思想
            PlegeEx();
        }

        /// <summary>
        /// 常规用法，耦合各个子系统
        /// </summary>
        static void Pledge()
        {
            Bank bank = new Bank();
            Credit credit = new Credit();
            Loan loan = new Loan();

            Customer customer = new Customer("张三");

            bool eligible = true;

            if(!bank.HasSuffcientSavings(customer,12000))
            {
                eligible = false;
            }
            else if(!credit.HasGoodGredit(customer))
            {
                eligible = false;
            }
            else if(!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }

            Console.WriteLine($"{customer.Name} has been {(eligible ? "Approved":"Rejected")}");

        }

        /// <summary>
        /// 使用外观类进行子系统和客户端之间解耦合，外观模式更多的是从整个结构角度去设计
        /// </summary>
        static void PlegeEx()
        {
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer("王五");
            bool bEligible = mortgage.IsEligible(customer, 12000);
            Console.WriteLine($"{customer.Name} has been {(bEligible ? "Approved" : "Rejected")}");
        }
    }
}

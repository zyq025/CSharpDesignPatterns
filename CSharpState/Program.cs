using System;

namespace CSharpState
{
    /// <summary>
    /// 状态模式;允许一个对象在其内部状态改变时自动改变其行为，对象看起来就像改变了它的类
    /// 举例：根据银行账户不同状态，改变其不同行为，银行状态简单分为：透支状态(RedState)，无利息状态(SilveState)，有利息状态(GoldState)
    /// 例子中相关类说明：
    /// Account类: 维护一个State类的一个实例，该实例标识着当前对象的状态
    /// State类: 抽象状态类，定义一个具体状态类需要实现的行为约定
    /// SilveState、GoldState和RedState类: 具体状态类，实现抽象状态类的每个行为
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //开一个新的账户
            Account account = new Account("Learning Hard");

            //进行交易
            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            //付利息
            account.PayInterest();

            //取钱
            account.Withdraw(2000.00);
            account.Withdraw(500.00);
        }
    }
}

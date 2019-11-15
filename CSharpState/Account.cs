using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpState
{
    public class Account
    {
        public State State { get; set; }
        public string OWner { get; set; }

        public Account(string owner)
        {
            this.OWner = owner;
            this.State = new SilverState(0.0, this);
        }
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get { return State.Balance; } }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"存款金额为:{amount:C}--");
            Console.WriteLine($"账户余额为:{Balance:C}--");
            Console.WriteLine($"账户状态:{this.State.GetType().Name:C}--");
        }

        // 取钱
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("取款金额为: {0:C}——", amount);
            Console.WriteLine("账户余额为:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        // 获得利息
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine("账户余额为:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}

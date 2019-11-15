using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpState
{
    /// <summary>
    /// Red State 意味着Account透支了
    /// </summary>
    public class RedState : State
    {

        public RedState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Interest = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if(Balance>UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }

        public override void PayInterest()
        {
            //没有利息
         
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            Console.WriteLine("你没有钱可以取了");
        }
    }
}

using System;

namespace CSharpState
{
    /// <summary>
    /// Silver State 意味着没有利息
    /// </summary>
    public class SilverState : State
    {

        public SilverState(State state):this(state.Balance,state.Account)
        {
        }

        public SilverState(double balance,Account account)
        {
            this.Balance = balance;
            this.Account = account;
            Interest = 0.00;
            LowerLimit = 0.00;
            UpperLimit = 1000.00;
        }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public override void Deposit(double amount)
        {
            Balance+=amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if(Balance<LowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if(Balance>UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }

        /// <summary>
        /// 获得利息
        /// </summary>
        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }
    }
}
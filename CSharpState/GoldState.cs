namespace CSharpState
{
    /// <summary>
    /// Gold Stae 意味着利息状态
    /// </summary>
    public class GoldState : State
    {

        public GoldState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Interest = 0.05;
            LowerLimit = 1000.00;
            UpperLimit = 1000000.00;
        }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
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

        private void StateChangeCheck()
        {
            if (Balance < 0.0)
            {
                Account.State = new RedState(this);
            }
            else if (Balance < LowerLimit)
            {
                Account.State = new SilverState(this);
            }

        }
    }
}
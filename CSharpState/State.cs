namespace CSharpState
{
    /// <summary>
    /// 抽象状态类
    /// </summary>
    public abstract class State
    {
        public Account Account { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        public double LowerLimit { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        public double UpperLimit { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Deposit(double amount);

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Withdraw(double amount);

        /// <summary>
        /// 获得利息
        /// </summary>
        public abstract void PayInterest();


    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFacade
{
    /// <summary>
    /// 贷款子系统
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"Check loans for {customer.Name}");
            return true;
        }
    }
}

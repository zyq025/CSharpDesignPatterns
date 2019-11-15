using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFacade
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Mortgage
    {
        private Bank bank = new Bank();
        private Credit credit = new Credit();
        private Loan loan = new Loan();

        public bool IsEligible(Customer customer,int ammount)
        {
            Console.WriteLine($"{customer.Name} applies for {ammount} loan");
            bool eligible = true;
            if (!bank.HasSuffcientSavings(customer, 12000))
            {
                eligible = false;
            }
            else if (!credit.HasGoodGredit(customer))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFacade
{
    /// <summary>
    /// 银行子系统
    /// </summary>
    public class Bank
    {
        public bool HasSuffcientSavings(Customer c,int amount)
        {
            Console.WriteLine($"Check bank for " + c.Name);
            return true;
        }
    }
}

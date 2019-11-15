using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFacade
{
    /// <summary>
    /// 信用子系统
    /// </summary>
    public class Credit
    {
        public bool HasGoodGredit(Customer customer)
        {
            Console.WriteLine($"Check credit for {customer.Name}");
            return true;
        }
    }
}

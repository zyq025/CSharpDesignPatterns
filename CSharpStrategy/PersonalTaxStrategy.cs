using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStrategy
{
    /// <summary>
    /// 个人所得税
    /// </summary>
    public class PersonalTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}

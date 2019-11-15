using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStrategy
{
    /// <summary>
    /// Context
    /// </summary>
    public class InterestOperation
    {
        private ITaxStrategy m_strategy;
        public InterestOperation(ITaxStrategy taxStrategy)
        {
            this.m_strategy = taxStrategy;
        }

        public double GetTax(double income)
        {
            return m_strategy.CalculateTax(income);
        }
    }
}

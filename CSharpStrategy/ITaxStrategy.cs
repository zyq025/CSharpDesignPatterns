using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStrategy
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITaxStrategy
    {
        double CalculateTax(double income);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIterator
{
    /// <summary>
    /// 抽象聚集
    /// </summary>
    public interface IList
    {
        IIterator GetIterator();
    }
}

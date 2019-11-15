using System;

namespace CSharpIterator
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    public interface IIterator
    {
        bool MoveNext();
        Object CurrentItem();

        void First();
        void Next();
    }
}
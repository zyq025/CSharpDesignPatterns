using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVistor
{
    /// <summary>
    /// 抽象元素角色
    /// </summary>
    public abstract class Element
    {
        public abstract void Print();
        public abstract void Accept(IVisitor visitor);
    }
}

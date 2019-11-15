using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVistor
{
    public class ConcreteVistor : IVisitor
    {
        public void Visit(ElementA elementA)
        {
            elementA.Print();
        }

        public void Visit(ElementB elementB)
        {
            elementB.Print();
        }
    }
}

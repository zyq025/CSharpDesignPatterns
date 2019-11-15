using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVistor
{
    public class ElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("A 来也");
        }
    }
}

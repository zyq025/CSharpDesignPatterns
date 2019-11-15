using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMotivate
{
    public class HundredExpression : Expression
    {
        public override string GetPostifix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
        public override int GetLength()
        {
            return 2;
        }
    }
}

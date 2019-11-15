using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMotivate
{
    public class ThousandExpression : Expression
    {
        public override string GetPostifix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override int GetLength()
        {
            return 2;
        }
    }
}

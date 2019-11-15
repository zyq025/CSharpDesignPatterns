using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMotivate
{
    public class OneExpression : Expression
    {
        public override string GetPostifix()
        {
            return "";
        }

        public override int Multiplier()
        {
            return 1;
        }
        public override int GetLength()
        {
            return 1;
        }
    }
}

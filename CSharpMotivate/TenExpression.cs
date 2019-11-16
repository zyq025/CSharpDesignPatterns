using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterpreter
{
    public class TenExpression : Expression
    {
        public override string GetPostifix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
        public override int GetLength()
        {
            return 2;
        }
    }
}

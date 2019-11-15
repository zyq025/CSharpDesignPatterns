using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMotivate
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

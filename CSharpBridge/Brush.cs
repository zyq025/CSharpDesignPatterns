using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridge
{
    public abstract class Brush
    {
        protected Color c;
        public abstract void Paint();

        public void SetColor(Color c)
        {
            this.c = c;
        }
    }
}

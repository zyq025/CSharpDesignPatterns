using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCommond
{
    public abstract class Commond
    {
        protected Receiver _receiver;

        protected Commond(Receiver receiver)
        {
            _receiver = receiver;
        }

        /// <summary>
        /// 命令执行方法
        /// </summary>
        public abstract void Action();
    }
}

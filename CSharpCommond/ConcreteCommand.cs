using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCommond
{
    /// <summary>
    /// 具体命令
    /// </summary>
    public class ConcreteCommand : Commond
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Action()
        {
            //调用接受者的方法，因为执行命令的是学生
            _receiver.Run1000Meters();
        }
    }
}

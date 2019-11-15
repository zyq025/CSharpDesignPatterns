using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCommond
{
    /// <summary>
    /// 教官 ,负责调用命令对象执行请求
    /// </summary>
    public class Invoke
    {
        public Commond _commond;

        public Invoke(Commond commond)
        {
            _commond = commond;
        }

        public void ExecuteCommand()
        {
            _commond.Action();
        }
    }
}

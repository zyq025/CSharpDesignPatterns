using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBuilder
{
    public class Computer
    {
        /// <summary>
        /// 电脑组件
        /// </summary>
        private IList<string> parts = new List<string>();

        /// <summary>
        /// 安装对应组件
        /// </summary>
        /// <param name="part">组件</param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始组装............");
            foreach(var part in parts)
            {
                Console.WriteLine($"组件{part}已经装好!");
            }
            Console.WriteLine("电脑组装好了");
        }

    }
}

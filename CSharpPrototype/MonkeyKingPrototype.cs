using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrototype
{
    /// <summary>
    /// 悟空原型
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }
        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// 克隆方法，就像悟空说：变
        /// </summary>
        /// <returns></returns>
        public abstract MonkeyKingPrototype Clone();
    }
}

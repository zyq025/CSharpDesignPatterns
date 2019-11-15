using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComposite
{
    /// <summary>
    /// 图形抽象类
    /// </summary>
    public abstract class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            this.Name = name;
        }
        public abstract void Draw();
        public abstract void Add(Graphics g);
        public abstract void Remove(Graphics g);

    }
}

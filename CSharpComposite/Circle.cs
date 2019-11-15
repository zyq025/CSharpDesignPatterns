using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComposite
{
    /// <summary>
    /// 简单图形  圆
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name) : base(name)
        {
        }

        public override void Add(Graphics g)
        {
            throw new Exception("不能在简单图形圆上增加图形");
        }

        public override void Draw()
        {
            Console.WriteLine($"画 {Name}");
        }

        public override void Remove(Graphics g)
        {
            throw new Exception("不能在简单图形圆上删除图形");
        }
    }
}

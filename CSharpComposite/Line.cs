using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComposite
{
    /// <summary>
    /// 简单图形  线
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) : base(name)
        {
        }

        public override void Add(Graphics g)
        {
            throw new Exception("不能向简单图形Line添加其他图形");
        }

        public override void Draw()
        {
            Console.WriteLine($"画 {Name}");
        }

        public override void Remove(Graphics g)
        {
            throw new Exception("不能向简单图形Line移除其他图形");
        }
    }
}

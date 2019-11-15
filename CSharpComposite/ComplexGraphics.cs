using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComposite
{
    /// <summary>
    /// 复杂图形，由简单图形组成，这里假设该复杂图形由一个圆两条线组成
    /// </summary>
    public class ComplexGraphics : Graphics
    {
        private List<Graphics> complexGraphicsList = new List<Graphics>();

        public ComplexGraphics(string name) : base(name)
        {
        }

        public override void Add(Graphics g)
        {
            complexGraphicsList.Add(g) ;
        }

        public override void Draw()
        {
            foreach(var g in complexGraphicsList)
            {
                g.Draw();
            }
        }

        public override void Remove(Graphics g)
        {
            complexGraphicsList.Remove(g);
        }
    }
}

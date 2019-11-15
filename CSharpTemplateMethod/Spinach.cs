using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTemplateMethod
{
    /// <summary>
    /// 菠菜
    /// </summary>
    public class Spinach : Vegetable
    {
        public override void PourVegetable()
        {
            Console.WriteLine("倒菠菜进锅中...");
        }

    }
}

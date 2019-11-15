using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTemplateMethod
{
    /// <summary>
    /// 大白菜
    /// </summary>
    public class ChineseCabbage : Vegetable
    {
        public override void PourVegetable()
        {
            Console.WriteLine("将大白菜倒入锅中");
        }
    }
}
